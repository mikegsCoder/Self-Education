const Cube = require('../models/Cube');
const Comment = require('../models/Comment');
const Accessory = require('../models/Accessory');

async function getAll(query) {
    const options = {};

    // filter cubes by query params:
    if (query.search) {
        options.name = { $regex: query.search, $options: 'i' };
    } 
    if (query.from) {
        options.difficulty = { $gte: Number(query.from) };
    }
    if (query.to) {
        options.difficulty = options.difficulty || {};
        options.difficulty.$lte = Number(query.to);
    }

    const cubes = Cube.find(options).lean();
    
    return cubes;
}

module.exports = {
    getAll
};