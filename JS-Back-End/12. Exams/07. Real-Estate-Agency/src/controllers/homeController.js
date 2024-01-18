const router = require('express').Router();

router.get('/', async (req, res) => {
    const items = await req.storage.getTopItems();

    res.render('home', { items });
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

router.get('/search', async (req, res) => {
    res.render('search');
});

module.exports = router;