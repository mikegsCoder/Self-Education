const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getTopItems() {
    return Item.find({}).sort({ createdAt: -1 }).limit(3).lean();
}

module.exports = {
    getAllItems,
    getTopItems
};