const mongoose = require('mongoose');

const schema = new mongoose.Schema({
    author: { type: mongoose.Schema.Types.ObjectId, ref: 'Person' },
    title: { type: String, required: true },
    content: { type: String, minLength: 10 },
    comments: [{ type: mongoose.Schema.Types.ObjectId, ref: 'Comment' }]
});

const Post = mongoose.model('Post', schema);

module.exports = Post;