const Course = require('../models/Course');
const User = require('../models/User');

async function getAllCourses(hasUser) {
    if (hasUser) {
        const sort = { createdAt: 'asc' };
        return Course.find({}).sort(sort).lean();
    } else {
        const sort = { usersEnrolled: 'desc' };
        return Course.find({}).sort(sort).limit(3).lean();
    }
}

module.exports = {
    getAllCourses
};