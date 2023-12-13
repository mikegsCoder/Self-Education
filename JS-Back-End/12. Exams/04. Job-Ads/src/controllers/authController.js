const router = require('express').Router();
const { body, validationResult } = require('express-validator');
const { isGuest } = require('../middlewares/guards');

router.get('/register', isGuest(), (req, res) => {
    res.render('register');
});

router.post('/register', isGuest(),
    body('email')
        .isEmail().withMessage('Plese enter a valid email.'),
    body('skills')
        .isLength({ min: 1 }).withMessage('Skills are required.')
        .isLength({ max: 40 }).withMessage('Skills description must be less than 40 characters long.'),
    body('password')
        .isLength({ min: 5 }).withMessage('Password must be at least 5 characters long.'),
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
                req.body.email, 
                req.body.password, 
                req.body.skills);

            res.redirect('/');
        } catch (err) {
            console.log(err.message)
            const ctx = {
                errors: err.message.split('\n'),
                userData: {
                    skills: req.body.skills,
                    email: req.body.email
                }
            }
            res.render('register', ctx);
        }
    }
);

module.exports = router;