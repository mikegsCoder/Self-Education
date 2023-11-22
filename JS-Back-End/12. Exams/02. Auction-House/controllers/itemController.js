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
            description: req.body.description.trim(),
            imageUrl: req.body.imageUrl.trim(),
            category: req.body.category,
            price: req.body.price,
            author: req.user._id
        };
        
        await req.storage.createItem(itemData);
        res.redirect('/');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            itemData: {
                title: req.body.title,
                description: req.body.description,
                imageUrl: req.body.imageUrl,
                category: req.body.category,
                price: req.body.price,
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
        item.isBidder = req.user && item.bidder == req.user._id;

        item.creator = item.author.firstName + ' ' + item.author.lastName;

        res.render('item/details', { item });
    } catch (err) {
        console.log(err.message);
        res.redirect('/404');
    }
});

module.exports = router;