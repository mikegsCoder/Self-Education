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

module.exports = router;