const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getTopItems() {
    return Item.find({}).sort({ createdAt: -1 }).limit(3).lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('owner').populate('rentedBy').lean();
}

async function createItem(itemData) {
    const item = new Item(itemData);
    await item.save();

    return item;
}

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.title = itemData.title.trim();
    item.type = itemData.type.trim();
    item.year = itemData.year;
    item.city = itemData.city.trim();
    item.imageUrl = itemData.imageUrl.trim();
    item.description = itemData.description.trim();
    item.pieces = itemData.pieces;

    return item.save();
}

module.exports = {
    getAllItems,
    getTopItems,
    getItemById,
    createItem,
    editItem
};