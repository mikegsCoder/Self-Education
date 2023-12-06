const User = require('../models/User');

async function createUser(email, hashedPassword, skills) {
    const user = new User({
        email,
        hashedPassword,
        skills
    });

    await user.save();

    return user;
}

module.exports = {
    createUser
};