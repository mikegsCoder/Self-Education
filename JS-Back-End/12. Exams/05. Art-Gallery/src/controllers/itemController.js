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
            technique: req.body.technique.trim(),
            imageUrl: req.body.imageUrl.trim(),
            certificate: req.body.certificate.trim(),
            author: req.user._id
        };
        
        await req.storage.createItem(itemData, req.user._id);
        res.redirect('/');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            itemData: {
                title: req.body.title,
                technique: req.body.technique,
                imageUrl: req.body.imageUrl,
                certificate: req.body.certificate
            }
        };

        res.render('item/create', ctx);
    }
});

module.exports = router;