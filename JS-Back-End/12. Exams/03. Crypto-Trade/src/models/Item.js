const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Title is required.'], 
        minLength: [2, 'Title must be at least 2 characters long.'] },
    imageUrl: { type: String, 
        required: [true, 'ImageUrl is required.'],
        match: [/^https?/, 'Image must be a valid URL.'] },
    price: { type: Number, 
        required: [true, 'Price is required.'],
        min: [0, 'Price must be a positive numer.'] },
    description: { type: String, 
        minLength: [10, 'Description must be more than 10 characters long.'] },
    paymentMethod: { type: String, 
        required: [true, 'Payment method is required.'],
        enum: ['crypto-wallet', 'credit-card', 'debit-card', 'paypal'] },
    author: { type: Schema.Types.ObjectId, ref: 'User' },
    buyCrypto: [{ type: Schema.Types.ObjectId, ref: 'User', default: [] }]
});

module.exports = model(ITEM, schema);