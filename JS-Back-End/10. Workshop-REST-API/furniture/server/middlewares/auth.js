const jwt = require('jsonwebtoken');
const { SECRET } = require('../config');

module.exports = () => (req, res, next) => {
    const token = req.headers['x-authorization'];

    try {
        if (token) {
            const userData = jwt.verify(token, SECRET);
            req.user = userData;
        }
    } catch (err) {
        console.log(err.message);
        // res.status(401).json({ message: 'Invalid access token. Please sign in.' });
    }

    next();
};
