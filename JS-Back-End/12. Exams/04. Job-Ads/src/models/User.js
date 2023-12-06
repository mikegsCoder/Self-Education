const { Schema, model } = require('mongoose');

const schema = new Schema({
    hashedPassword: { type: String, required: true },
    email: { type: String, required: true },
    skills: { type: String, required: true },
    myAds: [{ type: Schema.Types.ObjectId, ref: 'Ad', default: [] }]
});

module.exports = model('User', schema);