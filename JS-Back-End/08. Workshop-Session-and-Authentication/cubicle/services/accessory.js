const Accessory = require('../models/Accessory');

async function getAllAccessories(existing) {
    return Accessory.find({ _id: { $nin: existing }}).lean();
}

module.exports = {
    getAllAccessories
};