const router = require('express').Router();

const { isUser } = require('../middlewares/guards');

router.get('/create', isUser(), (req, res) => {
    res.render('hotel/create');
});

module.exports = router;