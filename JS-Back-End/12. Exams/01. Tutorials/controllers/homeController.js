const router = require('express').Router();

router.get('/', async (req, res) => {
    let courses;

    if (req.user) {
        courses = await req.storage.getAllCourses(true);
    } else {
        courses = (await req.storage.getAllCourses(false));
    }

    courses.map(x => x.date = x.createdAt.toString().slice(0, 24));

    res.render('home', { courses });
});

router.post('/search', async (req, res) => {
    const courses = await req.storage.searchCourses(req.body.search);
    
    courses.map(x => x.date = x.createdAt.toString().slice(0, 24));

    res.render('home', { courses });
});

module.exports = router;