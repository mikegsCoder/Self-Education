const router = require('express').Router();

const { isUser } = require('../middlewares/guards');

router.get('/', async (req, res) => {
    res.render('home');
});

router.get('/catalog', async (req, res) => {
    const items = await req.storage.getAllItems();

    res.render('catalog', { items });
});

router.get('/profile', isUser(), async(req, res) => {
    const userProfile = await req.storage.getUserProfile(req.user._id);
    userProfile.isMale = Boolean(userProfile.gender == 'male');
    userProfile.tripsCount = userProfile.trips.length;
    userProfile.hasTrips = Boolean(userProfile.tripsCount > 0);

    res.render('profile', { userProfile });
});

module.exports = router;