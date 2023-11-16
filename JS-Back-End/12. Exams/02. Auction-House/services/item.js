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

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.title = itemData.title.trim();
    item.description = itemData.description.trim();
    item.imageUrl = itemData.imageUrl.trim();
    item.category = itemData.category;
    item.price = itemData.price;

    return item.save();
}

async function deleteItem(id) {
    const item = await Item.findById(id);
    item.isClosed = true;

    return item.save();
}

async function bidItem(itemId, userId, price) {
    const item = await Item.findById(itemId);
    const user = await User.findById(userId)

    item.bidder = userId;
    item.price = price;
    user.auctionsPlaced.push(itemId);

    return Promise.all([user.save(), item.save()]);
}

async function searchItems(search) {
    const pattern = new RegExp(`${search}`, 'i');
    const items = await Item.find({ title: { $regex: pattern } }).lean();

    return items;
}

async function getClosedItems(userId) {
    const search = { isClosed: true, author: userId };
    return Item.find(search).populate('bidder').lean();
}

module.exports = {
    getAllItems,
    getItemById,
    createItem,
    editItem,
    deleteItem,
    bidItem,
    searchItems,
    getClosedItems
};