const router = require('express').Router();

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/browse', async (req, res) => {
    const items = await req.storage.getAllItems();

    const ctx = {
        items,
        title: 'Auctions',
        closed: false
    };

    res.render('browse', ctx);
});

module.exports = router;