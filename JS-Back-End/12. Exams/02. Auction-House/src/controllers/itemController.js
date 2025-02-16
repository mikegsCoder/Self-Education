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

router.get('/edit/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);
        
        if (item.author._id != req.user._id) {
            throw new Error(`Cannot edit ${ITEM.toLowerCase()} you haven\'t created.`);
        }

        item.hasBidder = Boolean(item.bidder);

        res.render('item/edit', { item });
    } catch (err) {
        console.log(err.message);
        res.redirect('/');
    }
});

router.post('/edit/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);
        
        if (item.author._id != req.user._id) {
            throw new Error(`Cannot edit ${ITEM.toLowerCase()} you haven\'t created.`);
        }

        await req.storage.editItem(req.params.id, req.body);

        res.redirect('/item/details/' + req.params.id); 
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            item: {
                _id: req.params.id,
                title: req.body.title,
                description: req.body.description,
                imageUrl: req.body.imageUrl,
                category: req.body.category,
                price: req.body.price
            }
        };

        res.render('item/edit', ctx);
    }
});

router.get('/delete/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);

        if (item.author._id != req.user._id) {
            throw new Error(`Cannot delete ${ITEM.toLowerCase()} you haven\'t created.`);
        }

        await req.storage.deleteItem(req.params.id);
        res.redirect('/browse');
    } catch (err) {
        console.log(err.message);
        res.redirect('/item/details/' + req.params.id);
    }
});

router.post('/bid/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);

        if (item.author._id == req.user._id) {
            throw new Error(`Cannot bid your own ${ITEM.toLowerCase()}.`);
        }
        
        if (req.body.bid <= item.price) {
            throw new Error('Price must be greater than current auction price.');
        }

        await req.storage.bidItem(req.params.id, req.user._id, req.body.bid);
        res.redirect('/item/details/' + req.params.id);
    } catch (err) {
        const item = await req.storage.getItemById(req.params.id);
        item.hasUser = Boolean(req.user);
        item.isAuthor = req.user && req.user._id == item.author._id;
        item.isBidder = req.user && item.bidder == req.user._id;

        item.creator = item.author.firstName + ' ' + item.author.lastName;

        const ctx = {
            errors: parseError(err),
            item
        }

         res.render('item/details', ctx);
    }
});

module.exports = router;