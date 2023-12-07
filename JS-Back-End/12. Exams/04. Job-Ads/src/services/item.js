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

module.exports = {
    getAllItems,
    getItemById
};