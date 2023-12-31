const itemService = require('../services/item');

module.exports = () => (req, res, next) => {
    req.storage = {
        ...itemService
    };

    next();
};