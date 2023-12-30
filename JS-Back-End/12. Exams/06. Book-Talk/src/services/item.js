const Item = require('../models/Item');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('owner').lean();
}

module.exports = {
    getAllItems,
    getItemById
};