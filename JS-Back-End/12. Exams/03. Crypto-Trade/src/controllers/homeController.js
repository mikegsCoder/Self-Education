const router = require('express').Router();

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

router.get('/search', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('search', { items });
});

router.post('/search', async (req, res) => {
    const items = await req.storage.searchItems(req.body.title, req.body.paymentMethod);

    console.log(req.body.title);
    console.log(req.body.paymentMethod);

    res.render('search', { items });
});

module.exports = router;