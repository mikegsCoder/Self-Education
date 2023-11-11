const router = require('express').Router();

const { isUser, isGuest } = require('../middlewares/guards');
const { parseError } = require('../util/parsers');

router.get('/create', isUser(), (req, res) => {
    res.render('course/create');
});

module.exports = router;