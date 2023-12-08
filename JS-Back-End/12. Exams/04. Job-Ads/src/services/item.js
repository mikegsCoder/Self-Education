const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getItemById(id) {
    let item = await Item.findById(id).populate('author').populate('usersApplyed').lean();

    return item;
}

async function createItem(itemData) {
    const item = new Item(itemData);
    await item.save();

    return item;
}

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.title = itemData.title.trim();
    item.location = itemData.location.trim();
    item.companyName = itemData.companyName.trim();
    item.companyDescription = itemData.companyDescription.trim();

    return item.save();
}

async function deleteItem(id) {
    return Item.findByIdAndDelete(id);
}

async function applyItem(itemId, userId) {
    const item = await Item.findById(itemId);

    item.usersApplyed.push(userId);

    return item.save();
}

module.exports = {
    getAllItems,
    getItemById,
    createItem,
    editItem,
    deleteItem,
    applyItem
};