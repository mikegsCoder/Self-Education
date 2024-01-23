const { Schema, model } = require('mongoose');

const schema = new Schema({
    hashedPassword: { type: String, required: true },
    email: { type: String, required: true },
    gender: { type: String, 
        required: [true, 'Gender is required.'],
        enum: ['male', 'female'] }
});

module.exports = model('User', schema);