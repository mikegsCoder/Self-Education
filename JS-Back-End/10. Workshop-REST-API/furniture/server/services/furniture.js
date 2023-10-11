const Furniture = require('../models/Furniture');

async function getAll() {
    return Furniture.find({}).lean();
}

async function create(data) {
    const result = new Furniture(data);
    await result.save();

    return result;
}

module.exports = {
    getAll,
    create
};