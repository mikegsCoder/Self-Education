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

async function getCourseById(id) {
    return Course.findById(id).populate('usersEnrolled').lean();
}

async function createCourse(courseData) {
    const pattern = new RegExp(`^${courseData.title}$`, 'i');
    const existing = await Course.findOne({ title: {$regex: pattern }});

    if (existing) {
        throw new Error('A course with this name already exists.');
    }

    const course = new Course(courseData);
    await course.save();

    return course;
}

async function editCourse(id, courseData) {
    const course = await Course.findById(id);

    course.title = courseData.title.trim();
    course.description = courseData.description.trim();
    course.imageUrl = courseData.imageUrl.trim();
    course.duration = courseData.duration.trim();

    return course.save();
}

async function deleteCourse(id) {
    return Course.findByIdAndDelete(id);
}

async function enrollCourse(courseId, userId) {
    const course = await Course.findById(courseId);
    const user = await User.findById(userId)

    course.usersEnrolled.push(userId);
    user.enrolledCourses.push(courseId);

    return Promise.all([user.save(), course.save()]);
}

module.exports = {
    getAllCourses,
    getCourseById,
    createCourse,
    editCourse,
    deleteCourse,
    enrollCourse
};