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

async function deleteItem(id) {
    return Item.findByIdAndDelete(id);
}

async function rentItem(itemId, userId) {
    const item = await Item.findById(itemId);

    item.rentedBy.push(userId);
    item.pieces--;

    return item.save();
}

async function searchItems(search) {
    const pattern = new RegExp(`${search}`, 'i');
    const items = await Item.find({ type: { $regex: pattern } }).lean();
   
    return items;
}

module.exports = {
    getAllItems,
    getTopItems,
    getItemById,
    createItem,
    editItem,
    deleteItem,
    rentItem,
    searchItems
};