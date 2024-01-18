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

router.post('/search', async (req, res) => {
    const items = await req.storage.searchItems(req.body.search);

    res.render('search', { items });
});

module.exports = router;