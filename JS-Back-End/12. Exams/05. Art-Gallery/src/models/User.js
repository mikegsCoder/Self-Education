const { Schema, model } = require('mongoose');

const schema = new Schema({
    hashedPassword: { type: String, required: true },
    username: { type: String, required: true },
    address: { type: String, required: true },
    publications: [{ type: Schema.Types.ObjectId, ref: 'Item', default: [] }]
});

module.exports = model('User', schema);