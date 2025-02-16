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

router.get('/details/:id', async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);

        item.hasUser = Boolean(req.user);
        item.isAuthor = req.user && req.user._id == item.owner._id;
        item.hasTenants = Boolean(item.rentedBy.length > 0);
        item.isAvailable = Boolean(item.pieces > 0);
        
        if (item.hasTenants) {
            item.isRented = req.user && item.rentedBy.find(u => u._id == req.user._id);
            item.tenants = item.rentedBy.map(x => x.name).join(', ');
        }

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

        item.hasBidder = Boolean(item.bidder);

        res.render('item/edit', { item });
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

router.post('/edit/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);
        
        if (item.owner._id != req.user._id) {
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
                type: req.body.type,
                year: req.body.year,
                city: req.body.city,
                imageUrl: req.body.imageUrl,
                description: req.body.description,
                pieces: req.body.pieces
            }
        };

        res.render('item/edit', ctx);
    }
});

router.get('/delete/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);

        if (item.owner._id != req.user._id) {
            throw new Error(`Cannot delete ${ITEM.toLowerCase()} you haven\'t created.`);
        }

        await req.storage.deleteItem(req.params.id);

        res.redirect('/catalog');
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

router.get('/rent/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);

        if (item.author == req.user._id) {
            throw new Error(`Cannot rent your own ${ITEM.toLowerCase()}.`);
        }
        
        await req.storage.rentItem(req.params.id, req.user._id);
        res.redirect('/item/details/' + req.params.id);
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

module.exports = router;