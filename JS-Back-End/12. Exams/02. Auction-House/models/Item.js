const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Title is required.'], 
        minLength: [4, 'Title must be at least 4 characters long.'] },
    description: { type: String, 
        maxLength: [200, 'Description must be less than 200 characters long.'] },
    category: { type: String, 
        required: [true, 'Category is required.'],
        enum: ['Vehicles', 'Real Estate', 'Electronics', 'Furniture', 'Other'] },
    imageUrl: { type: String, 
        required: [true, 'ImageUrl is required.'] },
    price: { type: Number, 
        required: [true, 'Price is required.'],
        min: [0, 'Price must be a positive numer.'] },
    author: { type: Schema.Types.ObjectId, ref: 'User' },
    bidder: { type: Schema.Types.ObjectId, ref: 'User' },
    isClosed: { type: Boolean, default: false }
});

module.exports = model(ITEM, schema);