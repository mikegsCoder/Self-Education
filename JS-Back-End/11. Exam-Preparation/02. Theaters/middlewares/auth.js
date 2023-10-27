const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');

const { TOKEN_SECRET, COOKIE_NAME } = require('../config');
const userService = require('../services/user');

module.exports = () => (req, res, next) => {
    if (parseToken(req, res)) {
        req.auth = {
            async register(username, password) {
                
            },
            async login(username, password) {
                
            },
            logout() {
                res.clearCookie(COOKIE_NAME);
            },
        };

        next();
    }
};

function generateToken(userData) {
    return jwt.sign(
        {
            _id: userData._id,
            username: userData.username,
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