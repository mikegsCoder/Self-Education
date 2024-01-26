const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');

const { TOKEN_SECRET, COOKIE_NAME } = require('../config');
const userService = require('../services/user');

module.exports = () => (req, res, next) => {
    if (parseToken(req, res)) {
        req.auth = {
            async register(email, gender, password) {
                const token = await register(email, gender, password);
                res.cookie(COOKIE_NAME, token);
            },
            async login(email, password) {
                const token = await login(email, password);
                res.cookie(COOKIE_NAME, token);
            },
            logout() {
                res.clearCookie(COOKIE_NAME);
            },
        };

        next();
    }
};

async function register(email, gender, password) {
    const existing = await userService.getUserByEmail(email);

    if (existing) {
        throw new Error('Email is taken.');
    }

    const hashedPassword = await bcrypt.hash(password, 10);
    const user = await userService.createUser(email, gender, hashedPassword);

    return generateToken(user);
}

async function login(email, password) {
}

function generateToken(userData) {
    return jwt.sign(
        {
            _id: userData._id,
            email: userData.email,
            gender: userData.gender
        },
        TOKEN_SECRET
    );
}

function parseToken(req, res) {
    const token = req.cookies[COOKIE_NAME];
    if (token) {
        try {
            const userData = jwt.verify(token, TOKEN_SECRET);
            req.user = userData;
            res.locals.user = userData;
        } catch (err) {
            res.clearCookie(COOKIE_NAME);
            res.redirect('/auth/login');

            return false;
        }
    }
    return true;
}
