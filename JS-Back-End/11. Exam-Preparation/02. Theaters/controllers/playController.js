const router = require('express').Router();

const { isUser, isGuest } = require('../middlewares/guards');

router.get('/create', isUser(), (req, res) => {
    res.render('play/create');
});

module.exports = router;