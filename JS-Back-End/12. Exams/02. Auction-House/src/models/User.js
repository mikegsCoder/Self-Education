const { Schema, model } = require('mongoose');

const { ITEM } = require('../config/index')

const schema = new Schema({
    hashedPassword: { type: String, required: true },
    email: { type: String, required: true },
    firstName: { type: String, required: true },
    lastName: { type: String, required: true },
    auctionsPlaced: [{ type: Schema.Types.ObjectId, ref: ITEM}]
});

module.exports = model('User', schema);