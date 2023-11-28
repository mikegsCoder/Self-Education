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

async function deleteItem(id) {
    return Item.findByIdAndDelete(id);
}

async function buyItem(itemId, userId) {
    const item = await Item.findById(itemId);
    const user = await User.findById(userId)

    item.buyCrypto.push(userId);

    return item.save();
}

async function searchItems(title, payment) {
    let items = await this.getAllItems();

    if (title) {
        items = items.filter(x => x.title.toLowerCase() == title.toLowerCase());
    }

    if (payment) {
        items =  items.filter(x => x.paymentMethod == payment);
    }

    return items;
}

module.exports = {
    getAllItems,
    getItemById,
    createItem,
    editItem,
    deleteItem,
    buyItem,
    searchItems
};