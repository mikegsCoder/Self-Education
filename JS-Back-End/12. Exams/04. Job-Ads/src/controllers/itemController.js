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
            location: req.body.location.trim(),
            companyName: req.body.companyName.trim(),
            companyDescription: req.body.companyDescription.trim(),
            author: req.user._id
        };
        
        await req.storage.createItem(itemData);
        res.redirect('/catalog');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            itemData: {
                title: req.body.title.trim(),
                location: req.body.location.trim(),
                companyName: req.body.companyName.trim(),
                companyDescription: req.body.companyDescription.trim()
            }
        };

        res.render('item/create', ctx);
    }
});

module.exports = router;