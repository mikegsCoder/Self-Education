const router = require('express').Router();

router.get('/', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('home' , { items });
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

module.exports = router;