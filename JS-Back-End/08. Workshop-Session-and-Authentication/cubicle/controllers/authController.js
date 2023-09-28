const { Router } = require('express');
const { isGuest, isAuth } = require('../middlewares/guards');

const router = Router();

router.get('/register', isGuest(), (req, res) => {
    res.render('register', { title: 'Register' });
});

module.exports = router;