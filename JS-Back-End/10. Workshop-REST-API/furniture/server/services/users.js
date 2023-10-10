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

async function login(email, password) {
    const user = await User.findOne({ email });

    if (!user) {
        const err = new Error('Incorrect email or password.');
        err.status = 401;
        throw err;
    }

    const match = await bcrypt.compare(password, user.hashedPassword);

    if (!match) {
        const err = new Error('Incorrect email or password.');
        err.status = 401;
        throw err;
    }

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

module.exports = {
    register,
    login
};