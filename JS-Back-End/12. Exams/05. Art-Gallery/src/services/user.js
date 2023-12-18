const User = require('../models/User');

async function createUser(address, hashedPassword, username) {
    const user = new User({
        address,
        hashedPassword,
        username
    });

    await user.save();
    return user;
}

async function getUserByUsername(username) {
    const pattern = new RegExp(`^${username}$`, 'i');
    const user = await User.findOne({ username: { $regex: pattern } });

    return user;
}

module.exports = {
    createUser,
    getUserByUsername
};