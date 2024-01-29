const router = require('express').Router();

const { isUser } = require('../middlewares/guards');

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

module.exports = router;