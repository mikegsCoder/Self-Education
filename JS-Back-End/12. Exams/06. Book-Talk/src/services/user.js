const User = require('../models/User');

async function createUser(email, hashedPassword, username) {
    const user = new User({
        email,
        hashedPassword,
        username
    });

    await user.save();

    return user;
}

module.exports = {
    createUser
};