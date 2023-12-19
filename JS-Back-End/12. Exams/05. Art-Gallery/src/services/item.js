const Item = require('../models/Item');
const User = require('../models/User');

const { ITEM } = require('../config/index');

async function getAllItems() {
    return Item.find({}).populate('author').populate('sharedBy').lean();
}

async function getItemById(id) {
    return Item.findById(id).populate('author').lean();
}

async function createItem(itemData, userId) {
    if (itemData.certificate != 'Yes' && itemData.certificate != 'No') {
        throw new Error('Enter a valid certificate info.');
    }

    const item = new Item(itemData);
    const user = await User.findById(userId);
    user.publications.push(item);

    await item.save();
    await user.save();

    return item;
}

async function editItem(id, itemData) {
    const item = await Item.findById(id);

    item.title = itemData.title.trim();
    item.technique = itemData.technique.trim();
    item.imageUrl = itemData.imageUrl.trim();
    item.certificate = itemData.certificate.trim();

    return item.save();
}

module.exports = {
    getAllItems,
    getItemById,
    createItem,
    editItem
};