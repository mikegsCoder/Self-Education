const router = require('express').Router();
const { body, validationResult } = require('express-validator');
const { isGuest } = require('../middlewares/guards');

router.get('/register', isGuest(), (req, res) => {
    res.render('register');
});

router.post('/register', isGuest(),
    body('name')
    .matches(/^([A-Z]{1})([a-z]+)(\s)([A-Z]{1})([a-z]+){1}$/).withMessage('Incorrect name'),
    body('username')
        .isLength({ min: 5 }).withMessage('Username must be at least 5 characters long.'),
    body('password')
        .isLength({ min: 4 }).withMessage('Password must be at least 4 characters long.'),
    body('rePass').custom((value, { req }) => {
        if (value != req.body.password) {
            throw new Error ('Passwords don\'t match.');
        }
        return true;
    }),
    async (req, res) => {
        const { errors } = validationResult(req);
        
        try {
            if (errors.length > 0) {
                throw new Error(Object.values(errors).map(e => e.msg).join('\n'));
            }

            await req.auth.register(
                req.body.name, 
                req.body.password, 
                req.body.username);

            res.redirect('/');
        } catch (err) {
            console.log(err.message)
            const ctx = {
                errors: err.message.split('\n'),
                userData: {
                    username: req.body.username,
                    name: req.body.name
                }
            }
            res.render('register', ctx);
        }
    }
);

router.get('/login', isGuest(), (req, res) => {
    res.render('login');
});

router.post('/login', isGuest(), async (req, res) => {
    try {
        await req.auth.login(req.body.username, req.body.password);

        res.redirect('/')
    } catch (err) {
        console.log(err.message);
        let errors = [err.message];
        if (err.type == 'credential') {
            errors = ['Incorrect Username or Password.'];
        }

        const ctx = {
            errors,
            userData: {
                username: req.body.username
            }
        }

        res.render('login', ctx);
    }
});

router.get('/logout', (req, res) => {
    req.auth.logout();
    res.redirect('/');
});

module.exports = router;