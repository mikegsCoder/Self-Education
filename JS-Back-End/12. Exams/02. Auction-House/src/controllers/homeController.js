const router = require('express').Router();

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/browse', async (req, res) => {
    const items = await req.storage.getAllItems();

    const ctx = {
        items,
        title: 'Auctions',
        closed: false
    };

    res.render('browse', ctx);
});

router.get('/closed', async (req, res) => {
    const items = await req.storage.getClosedItems(req.user._id);
    items.map(x => {
        if (x.bidder) {
            x.bidderName = x.bidder.firstName + ' ' + x.bidder.lastName;
        } else {
            x.bidderName = '';
        }
    })

    const ctx = {
        items,
        title: 'Closed Auctions',
        closed: true
    };

    res.render('browse', ctx);
});

module.exports = router;