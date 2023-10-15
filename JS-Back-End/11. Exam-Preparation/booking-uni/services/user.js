const User = require('../models/User');

async function createUser(username, email, hashedPassword) {
    const user = new User({
        username,
        email,
        hashedPassword
    });

    await user.save();

    return user;
}

module.exports = {
    createUser
};