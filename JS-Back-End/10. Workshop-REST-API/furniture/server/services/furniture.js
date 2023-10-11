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

async function update(original, updated) {
    Object.assign(original, updated);
    await original.save();

    return original;
}

module.exports = {
    getAll,
    getById,
    create,
    update
};