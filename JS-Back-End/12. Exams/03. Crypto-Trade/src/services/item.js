const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getItemById(id) {
    return Item.findById(id).lean();
}

async function createItem(itemData) {
    const item = new Item(itemData);
    await item.save();

    return item;
}

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.title = itemData.title.trim();
    item.description = itemData.description.trim();
    item.imageUrl = itemData.imageUrl.trim();
    item.paymentMethod = itemData.paymentMethod;
    item.price = itemData.price;

    return item.save();
}

module.exports = {
    getAllItems,
    getItemById,
    createItem,
    editItem
};