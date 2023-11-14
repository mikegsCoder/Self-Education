const User = require('../models/User');

async function createUser(email, hashedPassword, firstName, lastName) {
    const user = new User({
        email,
        hashedPassword,
        firstName,
        lastName
    });

    await user.save();

    return user;
}

module.exports = {
    createUser
};