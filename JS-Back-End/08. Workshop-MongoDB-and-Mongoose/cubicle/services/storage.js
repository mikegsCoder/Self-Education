const Cube = require('../models/Cube');
const Comment = require('../models/Comment');
const Accessory = require('../models/Accessory');

async function init() {
    return (req, res, next) => {
        req.storage = {
            getAll,
            getById,
            create,
            edit,
            createComment,
            createAccessory,
            getAllAccessories,
            attachSticker
        };

        next();
    };
}

async function getAll(query) {
    // some implementation
}

async function getById(id) {
    // some implementation
}

async function create(cube) {
    // some implementation
}

async function edit(id, cube) {
    // some implementation
}

async function createComment(cubeId, comment) {
    // some implementation
}

async function getAllAccessories(existing) {
    // some implementation
}

async function createAccessory(accessory) {
    // some implementation
}

async function attachSticker(cubeId, stickerId) {
    // some implementation
}

module.exports = {
    init,
    getAll,
    getById,
    create,
    createComment,
    createAccessory,
    getAllAccessories,
    attachSticker
};