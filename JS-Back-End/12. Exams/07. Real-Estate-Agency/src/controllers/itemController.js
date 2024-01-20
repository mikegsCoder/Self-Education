const router = require('express').Router();

const { isUser } = require('../middlewares/guards');
const { parseError } = require('../util/parsers');
const { ITEM } = require('../config/index');

router.get('/create', isUser(), (req, res) => {
    res.render('item/create');
});

router.post('/create', isUser(), async (req, res) => {
    try {
        const itemData = {
            title: req.body.title.trim(),
            type: req.body.type.trim(),
            year: req.body.year,
            city: req.body.city.trim(),
            imageUrl: req.body.imageUrl.trim(),
            description: req.body.description.trim(),
            pieces: req.body.pieces,
            owner: req.user._id
        };
        
        await req.storage.createItem(itemData);
        res.redirect('/');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            itemData: {
                title: req.body.title,
                type: req.body.type,
                year: req.body.year,
                city: req.body.city,
                imageUrl: req.body.imageUrl,
                description: req.body.description,
                pieces: req.body.pieces,
            }
        };

        res.render('item/create', ctx);
    }
});

module.exports = router;