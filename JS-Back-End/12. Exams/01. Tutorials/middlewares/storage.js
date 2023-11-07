const courseService = require('../services/course');

module.exports = () => (req, res, next) => {
    req.storage = {
        ...courseService
    };

    next();
};