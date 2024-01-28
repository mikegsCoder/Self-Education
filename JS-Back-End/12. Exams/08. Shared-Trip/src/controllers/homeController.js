const router = require('express').Router();

const { isUser } = require('../middlewares/guards');

router.get('/', async (req, res) => {
    res.render('home');
});

module.exports = router;