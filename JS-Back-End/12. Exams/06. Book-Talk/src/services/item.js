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

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.title = itemData.title.trim();
    item.author = itemData.author.trim();
    item.genre = itemData.genre.trim();
    item.stars = Number(itemData.stars);
    item.imageUrl = itemData.imageUrl.trim();
    item.review = itemData.review.trim();

    return item.save();
}

async function deleteItem(id) {
    return Item.findByIdAndDelete(id);
}

async function wishItem(itemId, userId) {
    const item = await Item.findById(itemId);
    item.wishingList.push(userId);

    return item.save();
}

module.exports = {
    getAllItems,
    getItemById,
    createItem,
    editItem,
    deleteItem,
    wishItem
};