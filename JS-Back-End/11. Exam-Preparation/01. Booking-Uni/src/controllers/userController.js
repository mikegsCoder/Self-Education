const router = require('express').Router();

router.get('/', async (req, res) => {
    const hotels = await req.storage.getBookedHotels(req.user._id);
    
    res.render('user/profile', { hotels });
});

module.exports = router;