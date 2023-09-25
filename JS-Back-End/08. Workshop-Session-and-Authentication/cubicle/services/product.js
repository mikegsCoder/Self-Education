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

async function getById(id) {
    const cube = await Cube
        .findById(id)
        .populate({
            path: 'comments',
            populate: { path: 'author' }
        })
        .populate('accessories')
        .populate('author')
        .lean();

    if (cube) {
        const viewModel = {
            _id: cube._id,
            name: cube.name,
            description: cube.description,
            imageUrl: cube.imageUrl,
            difficulty: cube.difficulty,
            comments: cube.comments.map(c => ({ content: c.content, author: c.author.username })),
            accessories: cube.accessories,
            author: cube.author && cube.author.username,
            authorId: cube.author && cube.author._id
        };
        return viewModel;
    } else {
        return undefined;
    }
}

module.exports = {
    getAll,
    getById
};