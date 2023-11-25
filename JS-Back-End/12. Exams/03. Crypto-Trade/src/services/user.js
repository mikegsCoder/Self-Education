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

async function getUserByEmail(email) {
    const pattern = new RegExp(`^${email}$`, 'i');
    const user = await User.findOne({ email: { $regex: pattern } });

    return user;
}

module.exports = {
    createUser,
    getUserByEmail
};