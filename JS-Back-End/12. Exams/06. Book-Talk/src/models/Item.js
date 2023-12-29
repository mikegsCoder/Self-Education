const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Title is required.'], 
        minLength: [2, 'Title must be at least 2 characters long.'] },
    imageUrl: { type: String, 
        required: [true, 'ImageUrl is required.'],
        match: [/^https?/, 'Image must be a valid URL.'] },
    stars: { type: Number, 
        required: [true, 'Stars are required.'],
        min: [1, 'Stars must be at least 1.'],
        max: [5, 'Stars must be at most 5.'] },
    review: { type: String, 
        minLength: [10, 'Review must be more than 10 characters long.'] },
    genre: { type: String, 
        required: [true, 'Genre is required.'],
        minLength: [3, 'Genre must be at least 3 characters long.'] },
    author: { type: String,
        required: [true, 'Autror is required.'],
        minLength: [5, 'Autror must be at least 5 characters long.'] },
    owner: { type: Schema.Types.ObjectId, ref: 'User' },
    wishingList: [{ type: Schema.Types.ObjectId, ref: 'User', default: [] }]
});

module.exports = model(ITEM, schema);