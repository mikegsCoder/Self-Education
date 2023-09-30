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

module.exports = router;