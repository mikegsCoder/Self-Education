const router = require('express').Router();

router.get('/', async (req, res) => {
    const items = await req.storage.getTopItems();

    res.render('home', { items });
});

module.exports = router;