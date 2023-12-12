const router = require('express').Router();

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

router.get('/search', async (req, res) => {
    const first = true;

    res.render('search', { first });
});

router.post('/search', async (req, res) => {
    const items = await req.storage.searchItems(req.body.searchEmail);

    const ctx = {
        searchEmail: req.body.searchEmail,
        items
    }

    res.render('search', ctx);
});

module.exports = router;