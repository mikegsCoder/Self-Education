const router = require('express').Router();

const { isUser, isGuest } = require('../middlewares/guards');
const { parseError } = require('../util/parsers');

router.get('/create', isUser(), (req, res) => {
    res.render('course/create');
});

router.post('/create', isUser(), async (req, res) => {
    try {
        const courseData = {
            title: req.body.title.trim(),
            description: req.body.description.trim(),
            imageUrl: req.body.imageUrl.trim(),
            duration: req.body.duration.trim(),
            author: req.user._id
        };
        
        await req.storage.createCourse(courseData);
        res.redirect('/');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            courseData: {
                title: req.body.title,
                description: req.body.description,
                imageUrl: req.body.imageUrl,
                duration: req.body.duration
            }
        };

        res.render('course/create', ctx);
    }
});

router.get('/details/:id', async (req, res) => {
    try {
        const course = await req.storage.getCourseById(req.params.id);
        course.hasUser = Boolean(req.user);
        course.isAuthor = req.user && req.user._id == course.author;
        course.isEnrolled = req.user && course.usersEnrolled.find(u => u._id == req.user._id);

        res.render('course/details', { course });
    } catch (err) {
        console.log(err.message);
        res.redirect('/404');
    }
});

router.get('/edit/:id', isUser(), async (req, res) => {
    try {
        const course = await req.storage.getCourseById(req.params.id);
        
        if (course.author != req.user._id) {
            throw new Error('Cannot edit course you haven\'t created.');
        }

        res.render('course/edit', { course });
    } catch (err) {
        console.log(err.message);
        res.redirect('/');
    }
});

router.post('/edit/:id', isUser(), async (req, res) => {
    try {
        const course = await req.storage.getCourseById(req.params.id);
        
        if (course.author != req.user._id) {
            throw new Error('Cannot edit course you haven\'t created.');
        }

        await req.storage.editCourse(req.params.id, req.body);
        res.redirect('/course/details/' + req.params.id);
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            course: {
                _id: req.params.id,
                title: req.body.title,
                description: req.body.description,
                imageUrl: req.body.imageUrl,
                duration: req.body.duration
            }
        };

        res.render('course/edit', ctx);
    }
});

router.get('/delete/:id', isUser(), async (req, res) => {
    try {
        const course = await req.storage.getCourseById(req.params.id);

        if (course.author != req.user._id) {
            throw new Error('Cannot delete course you haven\'t created.');
        }

        await req.storage.deleteCourse(req.params.id);
        res.redirect('/');
    } catch (err) {
        console.log(err.message);
        res.redirect('/course/details/' + req.params.id);
    }
});

module.exports = router;