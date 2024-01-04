const router = require('express').Router();

router.get('/', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('home' , { items });
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

router.get('/profile', async (req, res) => {
    const items = await req.storage.getWishedItems(req.user._id);

    res.render('profile', { items });
});

module.exports = router;