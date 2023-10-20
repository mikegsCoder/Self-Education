const router = require('express').Router();
const { body, validationResult } = require('express-validator');

router.get('/register', isGuest(), (req, res) => {
    res.render('user/register');
});

module.exports = router;