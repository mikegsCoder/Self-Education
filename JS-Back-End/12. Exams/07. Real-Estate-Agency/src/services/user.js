const User = require('../models/User');

async function createUser(name, hashedPassword, username) {
    const user = new User({
        name,
        hashedPassword,
        username
    });

    await user.save();
    return user;
}

module.exports = {
    createUser
};