const mongoose = require('mongoose');

const schema = new mongoose.Schema({
    author: { type: mongoose.Schema.Types.ObjectId, ref: 'Person' },
    content: { type: String, required: true },
    post: { type: mongoose.Schema.Types.ObjectId, ref: 'Post' }
});

const Comment = mongoose.model('Comment', schema);

module.exports = Comment;