const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Name is required.'], 
        minLength: [6, 'Name must be at least 6 characters long.'] },
    type: { type: String, 
        required: [true, 'Type is required.'], 
        enum: ['Apartment', 'Villa', 'House'] },
    year: { type: Number, 
        required: [true, 'Year is required.'],
        min: [1850, 'Year must be a between 1850 and 2021.'],
        max: [2021, 'Year must be a between 1850 and 2021.'] },
    city: { type: String, 
        required: [true, 'City is required.'], 
        minLength: [4, 'City must be at least 4 characters long.'] },
    imageUrl: { type: String, 
        required: [true, 'ImageUrl is required.'],
        match: [/^https?/, 'Image must be a valid URL.'] },
    description: { type: String, 
        maxLength: [60, 'Description must be less than 60 characters long.'] },
    pieces: { type: Number, 
        required: [true, 'Pieces are required.'],
        min: [0, 'Pieces must be a positive numer.'] },
    createdAt: { type: Date, default: Date.now },
    owner: { type: Schema.Types.ObjectId, ref: 'User' },
    rentedBy: [{ type: Schema.Types.ObjectId, ref: 'User', default: [] }],
});

module.exports = model(ITEM, schema);