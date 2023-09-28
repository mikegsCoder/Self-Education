const { Router } = require('express');
const { isGuest, isAuth } = require('../middlewares/guards');

const router = Router();

router.get('/register', isGuest(), (req, res) => {
    res.render('register', { title: 'Register' });
});

router.post('/register', isGuest(), async (req, res) => {
    try {
        await req.auth.register(req.body);
        res.redirect('/products');
    } catch (err) {
        const ctx = { 
            title: 'Register', 
            error: err.message, 
            data: { username: req.body.username } 
        };
        res.render('register', ctx);
    }
});

module.exports = router;