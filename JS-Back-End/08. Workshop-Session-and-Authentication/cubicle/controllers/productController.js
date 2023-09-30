const { Router } = require('express');

const { isAuth, isOwner } = require('../middlewares/guards');
const { preloadCube } = require('../middlewares/preload');

const router = Router();

router.get('/', async (req, res) => {
    const cubes = await req.storage.getAll(req.query);

    const ctx = {
        title: 'Cubicle',
        cubes,
        search: req.query.search || '',
        from: req.query.from || '',
        to: req.query.to || ''
    }

    res.render('index', ctx);
});

router.get('/create', isAuth(), (req, res) => {
    res.render('create', {title: 'Create Cube'});
});

router.post('/create', isAuth(), async (req, res) => {
    const cube = {
        name: req.body.name,
        description: req.body.description,
        imageUrl: req.body.imageUrl,
        difficulty: Number(req.body.difficulty),
        author: req.user._id
    };

    try {
        await req.storage.create(cube);
    } catch (err) {
        if (err.name == 'ValidationError') {
            return res.render('create', { title: 'Create Cube', error: 'Invalid data provided.' });
        }
    }

    res.redirect('/');
});

router.get('/details/:id', preloadCube(), async (req, res) => {
    const cube = req.data.cube;

    if (cube == undefined) {
        res.redirect('/404');
    } else {
        cube.isOwner = req.user && (cube.authorId == req.user._id);

        const ctx = {
            title: 'Cubicle',
            cube
        };

        res.render('details', ctx);
    }
});

module.exports = router;