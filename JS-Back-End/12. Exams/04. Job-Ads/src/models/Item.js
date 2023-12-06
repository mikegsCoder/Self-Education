const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    title: { type: String, 
        required: [true, 'Title is required.'], 
        minLength: [4, 'Title must be at least 4 characters long.'] },
    location: { type: String, 
        required: [true, 'Location is required.'] ,
        minLength: [8, 'Location must be at least 8 characters long.'] },
    companyName: { type: String, 
        required: [true, 'Company name is required.'] ,
        minLength: [3, 'Company name must be at least 3 characters long.'] },
    companyDescription: { type: String, 
        required: [true, 'Company description is required.'] ,
        maxLength: [40, 'Company description must be less than 40 characters long.'] },
    author: { type: Schema.Types.ObjectId, ref: 'User' },
    usersApplyed: [{ type: Schema.Types.ObjectId, ref: 'User', default: [] }]
});

module.exports = model(ITEM, schema);