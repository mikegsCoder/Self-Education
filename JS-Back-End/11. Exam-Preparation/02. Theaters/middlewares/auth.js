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