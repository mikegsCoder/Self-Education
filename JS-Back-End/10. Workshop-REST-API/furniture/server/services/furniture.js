const Furniture = require('../models/Furniture');

async function getAll() {
    return Furniture.find({}).lean();
}

module.exports = {
    getAll
};