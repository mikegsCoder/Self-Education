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

router.get('/details/:id', async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);
        item.hasUser = Boolean(req.user);
        item.isAuthor = req.user && req.user._id == item.author._id;
        item.isShared = req.user && item.sharedBy.find(u => u == req.user._id);

        res.render('item/details', { item });
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

module.exports = router;