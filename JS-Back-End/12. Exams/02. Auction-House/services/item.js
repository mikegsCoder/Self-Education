const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    const search = { isClosed: false };
    return Item.find(search).lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('author').populate('bidder').lean();
}

module.exports = {
    getAllItems,
    getItemById
};