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

async function createItem(itemData) {
    const pattern = new RegExp(`^${itemData.title}$`, 'i');
    const existing = await Item.findOne({ title: {$regex: pattern }});

    if (existing) {
        throw new Error(`${ITEM} with this name already exists.`);
    }

    const item = new Item(itemData);
    await item.save();

    return item;
}

module.exports = {
    getAllItems,
    getItemById,
    createItem
};