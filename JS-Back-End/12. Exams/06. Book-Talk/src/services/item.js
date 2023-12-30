const Item = require('../models/Item');

async function getAllItems() {
    return Item.find({}).lean();
}

module.exports = {
    getAllItems
};