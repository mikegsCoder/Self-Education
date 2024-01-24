const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('author').populate('buddies').lean();
}

module.exports = {
    getAllItems,
    getItemById
};