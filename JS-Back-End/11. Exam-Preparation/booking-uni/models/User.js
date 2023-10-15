const { Schema, model } = require('mongoose');

const schema = new Schema({
    username: { type: String, required: true },
    email: { type: String, required: true },
    hashedPassword: { type: String, required: true },
    bookedHotels: [{ type: Schema.Types.ObjectId, ref: 'Hotel', default: [] }]
});

module.exports = model('User', schema);