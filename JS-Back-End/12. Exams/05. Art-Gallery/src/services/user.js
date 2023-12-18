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

module.exports = {
    createUser
};