const { Schema, model } = require('mongoose');

const NAME_PATTERN = /^[a-zA-Z0-9 ]+$/;
const IMAGE_PATTERN = /^https?:\/\//;

const schema = new Schema({
    name: { 
        type: String, 
        required: [true, 'Cube name is required.'], 
        minLength: [5, 'Cube name must be at least 5 characters long.'], 
        match: [NAME_PATTERN, 'Cube name may contain only latin alphanumeric characters.'] 
    },
    description: { 
        type: String, 
        required: [true, 'Cube description is required.'], 
        minLength: [20, 'Cube description must be at least 20 characters long.'], 
        maxLength: [500, 'Cube description must be at most 500 characters long.'], 
        match: [NAME_PATTERN, 'Cube description may contain only latin alphanumeric characters.'] 
    },
    imageUrl: { 
        type: String, 
        required: [true, 'Image URL is required.'], 
        match: [IMAGE_PATTERN, 'Invalid image URL.'] 
    },
    difficulty: { type: Number, min: 1, max: 6 },
    comments: [{ type: Schema.Types.ObjectId, ref: 'Comment' }],
    accessories: [{ type: Schema.Types.ObjectId, ref: 'Accessory' }],
    author: { type: Schema.Types.ObjectId, ref: 'User' }
});

module.exports = model('Cube', schema);