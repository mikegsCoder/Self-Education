const User = require('../models/User');

async function createUser(email, gender, hashedPassword) {
    const user = new User({
        email,
        gender,
        hashedPassword
    });

    await user.save();
    return user;
}

module.exports = {
    createUser
};