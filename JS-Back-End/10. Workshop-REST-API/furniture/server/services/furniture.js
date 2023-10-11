const Furniture = require('../models/Furniture');

async function getAll() {
    return Furniture.find({}).lean();
}

async function create(data) {
    const result = new Furniture(data);
    await result.save();

    return result;
}

async function getById(id) {
    return Furniture.findById(id);
}

module.exports = {
    getAll,
    getById,
    create
};