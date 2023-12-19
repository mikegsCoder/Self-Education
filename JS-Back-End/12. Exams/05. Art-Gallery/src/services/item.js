const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).populate('author').populate('sharedBy').lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('author').lean();
}

module.exports = {
    getAllItems,
    getItemById
};