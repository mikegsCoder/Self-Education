const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');

const User = require('../models/User');
const { SECRET } = require('../config');

async function register(email, password) {
    // check if user exists
    const existing = await User.findOne({ email });

    if (existing) {
        const err = new Error('User with this email already exists in the database.');
        err.status = 409;
        throw err;
    }

    // hash password
    const hashedPassword = await bcrypt.hash(password, 10);

    // store user
    const user = new User({
        email,
        hashedPassword
    });

    await user.save();

    return {
        _id: user._id,
        email: user.email,
        accessToken: createToken(user)
    };
}

function createToken(user) {
    const token = jwt.sign({
        _id: user._id,
        email: user.email
    }, SECRET);

    return token;
}
