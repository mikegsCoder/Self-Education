const bcrypt = require("bcrypt");
const jwt = require("jsonwebtoken");

const { TOKEN_SECRET, COOKIE_NAME } = require("../config");
const userService = require("../services/user");

module.exports = () => (req, res, next) => {
    if (parseToken(req, res)) {
        req.auth = {
            async register(username, email, password) {
                const token = await register(username, email, password);
                res.cookie(COOKIE_NAME, token);
            },
            async login(username, password) {
                const token = await login(username, password);
                res.cookie(COOKIE_NAME, token);
            },
            logout() {
                res.clearCookie(COOKIE_NAME);
            },
        };

        next();
    }
};

async function register(username, email, password) {
    // to add implementation
}

async function login(username, password) {
    // to add implementation
}

function generateToken(userData) {
    // to add implementation
}

function parseToken(req, res) {
    // to add implementation
}
