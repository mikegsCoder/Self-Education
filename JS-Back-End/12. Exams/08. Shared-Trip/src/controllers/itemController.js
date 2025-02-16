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
            startPoint: req.body.startPoint.trim(),
            endPoint: req.body.endPoint.trim(),
            date: req.body.date,
            time: req.body.time,
            carImage: req.body.carImage.trim(),
            carBrand: req.body.carBrand.trim(),
            seats: Number(req.body.seats),
            price: Number(req.body.price),
            description: req.body.description.trim(),
            author: req.user._id
        };
        
        await req.storage.createItem(itemData);
        res.redirect('/catalog');
    } catch (err) {
        const ctx = {
            errors: parseError(err),
            itemData: {
                startPoint: req.body.startPoint,
                endPoint: req.body.endPoint,
                date: req.body.date,
                time: req.body.time,
                carImage: req.body.carImage,
                carBrand: req.body.carBrand,
                seats: req.body.seats,
                price: req.body.price,
                description: req.body.description,
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
        item.isBuddy = req.user && item.buddies.find(b => b._id == req.user._id);
        item.freeSeats = item.seats - item.buddies.length;
        item.hasSeats = Boolean(item.freeSeats > 0);
        item.isJoined = Boolean(item.buddies.length > 0);

        if (item.isJoined) {
            item.joinedBy = item.buddies.map(b => b.email).join(', ');
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
        
        if (item.author._id != req.user._id) {
            throw new Error(`Cannot edit ${ITEM.toLowerCase()} you haven\'t created.`);
        }

        res.render('item/edit', { item });
    } catch (err) {
        console.log(err.message);
        res.render('404');
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
                startPoint: req.body.startPoint,
                endPoint: req.body.endPoint,
                date: req.body.date,
                time: req.body.time,
                carImage: req.body.carImage,
                carBrand: req.body.carBrand,
                seats: req.body.seats,
                price: req.body.price,
                description: req.body.description
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
        res.redirect('/catalog');
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

router.get('/join/:id', isUser(), async (req, res) => {
    try {
        const item = await req.storage.getItemById(req.params.id);

        if (item.author == req.user._id) {
            throw new Error(`Cannot join your own ${ITEM.toLowerCase()}.`);
        }
        
        await req.storage.joinItem(req.params.id, req.user._id);
        res.redirect('/item/details/' + req.params.id);
    } catch (err) {
        console.log(err.message);
        res.render('404');
    }
});

module.exports = router;