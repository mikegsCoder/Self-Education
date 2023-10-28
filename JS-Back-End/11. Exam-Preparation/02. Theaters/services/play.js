const Play = require('../models/Play');

async function getAllPlays(orderBy) {
    let sort = { createdAt: -1 };
    if (orderBy == 'likes') {
        sort = { usersLiked: 'desc' };
    }

    return Play.find({ public: true }).sort(sort).lean();
}

async function getPlayById(id) {
    return Play.findById(id).populate('usersLiked').lean();
}

module.exports = {
    getAllPlays,
    getPlayById
};