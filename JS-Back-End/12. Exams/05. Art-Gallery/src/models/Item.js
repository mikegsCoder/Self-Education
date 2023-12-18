const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Title is required.'], 
        minLength: [6, 'Title must be at least 6 characters long.'] },
    technique: { type: String, 
        maxLength: [15, 'Painting technique must at most 15 characters long.'] },
    imageUrl: { type: String, 
        required: [true, 'ImageUrl is required.'],
        match: [/^https?/, 'Image must be a valid URL.'] },
    certificate: { type: String, 
        required: [true, 'Certificate info is required.'],
        enum: ['Yes', 'No'] },
    author: { type: Schema.Types.ObjectId, ref: 'User' },
    sharedBy: [{ type: Schema.Types.ObjectId, ref: 'User', default: [] }]
});

module.exports = model(ITEM, schema);