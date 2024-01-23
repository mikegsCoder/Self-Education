const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    startPoint: { type: String, 
        required: [true, 'Start point is required.'], 
        minLength: [4, 'Start point must be at least 4 characters long.'] },
    endPoint: { type: String, 
        required: [true, 'End point is required.'], 
        minLength: [4, 'End point must be at least 4 characters long.'] },
    date: { type: String, 
        required: [true, 'Date is required.'] },
    time: { type: String, 
        required: [true, 'Time is required.'] },
    carImage: { type: String, 
        required: [true, 'Car image is required.'],
        match: [/^https?/, 'Image must be a valid URL.'] },
    carBrand: { type: String, 
        required: [true, 'Car brand is required.'],
        minLength: [4, 'Car brand must be at least 4 characters long.'] },
    seats: { type: Number, 
        required: [true, 'Seats are required.'],
        min: [0, 'Seats must be between 0 and 4.'] ,
        max: [4, 'Seats must be between 0 and 4.'] },
    price: { type: Number, 
        required: [true, 'Price is required.'],
        min: [1, 'Price must be a positive numer.'],
        max: [50, 'Price must be less or equal 50.'] },
    description: { type: String, 
        required: [true, 'Description is required.'],
        minLength: [10, 'Description must be more than 10 characters long.'] },
    author: { type: Schema.Types.ObjectId, ref: 'User' },
    buddies: [{ type: Schema.Types.ObjectId, ref: 'User', default: [] }]
});

module.exports = model(ITEM, schema);