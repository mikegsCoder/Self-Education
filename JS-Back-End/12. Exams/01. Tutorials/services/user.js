const User = require('../models/User');

async function createUser(username, hashedPassword) {
    const user = new User({
        username,
        hashedPassword,
        likedPlays: []
    });

    await user.save();

    return user;
}

module.exports = {
    createUser
};