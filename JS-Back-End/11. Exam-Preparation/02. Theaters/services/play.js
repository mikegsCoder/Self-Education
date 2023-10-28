const Play = require('../models/Play');

async function getAllPlays(orderBy) {
    let sort = { createdAt: -1 };
    if (orderBy == 'likes') {
        sort = { usersLiked: 'desc' };
    }

    return Play.find({ public: true }).sort(sort).lean();
}

module.exports = {
    getAllPlays
};