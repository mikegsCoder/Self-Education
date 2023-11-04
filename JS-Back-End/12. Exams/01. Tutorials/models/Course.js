const { Schema, model } = require('mongoose');
const database = require('../config/database');

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Title is required.'], 
        minLength: [4, 'Title must be at least 4 characters long.'] },
    description: { type: String, 
        required: [true, 'Description is required.'], 
        minLength: [20, 'Description must be at least 20 characters long.'], maxLength: [50, 'Description must be less than 50 characters long.'] },
    imageUrl: { type: String, 
        required: [true, 'ImageUrl is required.'] },
    duration: { type: String, 
        required: [true, 'Duration is required.'] },
    createdAt: { type: Date, 
        default: Date.now },
    usersEnrolled: [{ type: Schema.Types.ObjectId, 
        ref: 'User', default: [] }],
    author: { type: Schema.Types.ObjectId, 
        ref: 'User' }
});

module.exports = model('Course', schema);