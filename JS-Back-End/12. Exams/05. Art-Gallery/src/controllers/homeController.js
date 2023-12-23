const router = require('express').Router();

router.get('/', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('home', { items });
});

module.exports = router;