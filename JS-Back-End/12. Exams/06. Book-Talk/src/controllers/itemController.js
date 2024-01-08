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
            author: req.body.author.trim(),
            genre: req.body.genre.trim(),
            stars: req.body.stars,
            imageUrl: req.body.imageUrl.trim(),
            review: req.body.review.trim(),
            owner: req.user._id
        };
        
        await req.storage.createItem(itemData);
        res.redirect('/');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            itemData: {
                title: req.body.title,
                author: req.body.author,
                genre: req.body.genre,
                stars: req.body.stars,
                imageUrl: req.body.imageUrl,
                review: req.body.review
            }
        };

        res.render('item/create', ctx);
    }
});

router.get('/details/:id', async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);
        item.hasUser = Boolean(req.user);
        item.isOwner = req.user && req.user._id == item.owner._id;
        item.isWished = req.user && item.wishingList.find(u => u == req.user._id);

        res.render('item/details', { item });
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

router.get('/edit/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);
        
        if (item.owner._id != req.user._id) {
            throw new Error(`Cannot edit ${ITEM.toLowerCase()} you haven\'t created.`);
        }

        res.render('item/edit', { item });
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

module.exports = router;