const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('author').populate('buddies').lean();
}

async function createItem(itemData) {
    const item = new Item(itemData);
    await item.save();

    return item;
}

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.startPoint = itemData.startPoint.trim();
    item.endPoint = itemData.endPoint.trim();
    item.date = itemData.date;
    item.time = itemData.time;
    item.carImage = itemData.carImage.trim();
    item.carBrand = itemData.carBrand.trim();
    item.seats = Number(itemData.seats);
    item.price = Number(itemData.price);
    item.description = itemData.description.trim();

    return item.save();
}

async function deleteItem(id) {
    return Item.findByIdAndDelete(id);
}

module.exports = {
    getAllItems,
    getItemById,
    createItem, 
    editItem,
    deleteItem
};