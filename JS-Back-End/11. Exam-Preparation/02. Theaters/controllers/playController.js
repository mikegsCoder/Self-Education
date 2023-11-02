const router = require('express').Router();

const { isUser, isGuest } = require('../middlewares/guards');

router.get('/create', isUser(), (req, res) => {
    res.render('play/create');
});

router.post('/create', isUser(), async (req, res) => {
    try {
        const playData = {
            title: req.body.title.trim(),
            description: req.body.description.trim(),
            imageUrl: req.body.imageUrl.trim(),
            public: Boolean(req.body.public),
            author: req.user._id
        };

        await req.storage.createPlay(playData);

        res.redirect('/');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            playData: {
                title: req.body.title,
                description: req.body.description,
                imageUrl: req.body.imageUrl,
                public: Boolean(req.body.public)
            }
        };
        res.render('play/create', ctx);
    }
});

module.exports = router;