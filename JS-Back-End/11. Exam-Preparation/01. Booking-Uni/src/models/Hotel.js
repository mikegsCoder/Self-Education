const { Schema, model } = require('mongoose');

const schema = new Schema({
    name: { type: String, required: [true, 'Name is required.'], minLength: 4 },
    city: { type: String, required: [true, 'City is required.'], minLength: 3 },
    imageUrl: { type: String, required: [true, 'ImageUrl is required.'], match: [/^https?/, 'Image must be a valid URL.'] },
    rooms: { type: Number, required: [true, 'Rooms are required.'], min: 1, max: 100 },
    bookedBy: [{ type: Schema.Types.ObjectId, ref: 'User' }],
    owner: { type: Schema.Types.ObjectId, ref: 'User', required: true } 
});

module.exports = model('Hotel', schema);