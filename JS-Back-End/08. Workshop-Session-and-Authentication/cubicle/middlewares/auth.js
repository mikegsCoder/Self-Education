const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');
const { COOKIE_NAME, TOKEN_SECRET } = require('../config');

const userService = require('../services/user');

module.exports = () => (req, res, next) => {
    req.auth = {
        register,
        login,
        logout
    };
}

