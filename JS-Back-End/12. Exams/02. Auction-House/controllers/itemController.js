const router = require('express').Router();

const { isUser } = require('../middlewares/guards');
const { ITEM } = require('../config/index');

router.get('/create', isUser(), (req, res) => {
    res.render('item/create');
});

module.exports = router;