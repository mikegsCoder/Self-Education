const Item = require('../models/Item');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('owner').lean();
}

async function createItem(itemData) {
    const item = new Item(itemData);
    await item.save();

    return item;
}

module.exports = {
    getAllItems,
    getItemById,
    createItem
};