const router = require('express').Router();

const { isUser } = require('../middlewares/guards');

router.get('/create', isUser(), (req, res) => {
    res.render('hotel/create');
});

router.post('/create', isUser(), async (req, res) => {
    const hotelData = {
        name: req.body.name,
        city: req.body.city,
        imageUrl: req.body.imageUrl,
        rooms: req.body.rooms,
        bookedBy: [],
        owner: req.user._id 
    };

    try {
        await req.storage.createHotel(hotelData);

        res.redirect('/');
    } catch (err) {
        console.log(err.message);

        let errors;
        if (err.errors) {
            errors = Object.values(err.errors).map(e => e.properties.message);
        } else {
            errors = [err.message];
        }
        
        const ctx = {
            errors: errors,
            hotelData: {
                name: req.body.name,
                city: req.body.city,
                imageUrl: req.body.imageUrl,
                rooms: req.body.rooms
            }
        };

        res.render('hotel/create', ctx);
    }
});

router.get('/details/:id', async (req, res) => {
    try {
        const hotel = await req.storage.getHotelById(req.params.id);
        hotel.hasUser = Boolean(req.user);
        hotel.isAuthor = req.user && req.user._id == hotel.owner;
        hotel.isBooked = req.user && hotel.bookedBy.find(x => x == req.user._id);

        res.render('hotel/details', { hotel });
    } catch (err) {
        console.log(err.message);
        res.redirect('/404');
    }
});

router.get('/edit/:id', isUser(), async (req, res) => {
    try {
        const hotel = await req.storage.getHotelById(req.params.id);

        if (req.user._id != hotel.owner) {
            throw new Error('Cannot edit hotel you haven\'t created.');
        }

        res.render('hotel/edit', { hotel });
    } catch (err) {
        console.log(err.message);
        res.redirect('/');
    }
});

router.post('/edit/:id', isUser(), async (req, res) => {
    try {
        const hotel = await req.storage.getHotelById(req.params.id);

        if (req.user._id != hotel.owner) {
            throw new Error('Cannot edit hotel you haven\'t created.');
        }

        await req.storage.editHotel(req.params.id, req.body);

        res.redirect('/');
    } catch (err) {
        console.log(err.message);

        let errors;
        if (err.errors) {
            errors = Object.values(err.errors).map(e => e.properties.message);
        } else {
            errors = [err.message];
        }
        
        const ctx = {
            errors: errors,
            hotel: {
                _id: req.params.id,
                name: req.body.name,
                city: req.body.city,
                imageUrl: req.body.imageUrl,
                rooms: req.body.rooms
            }
        };

        res.render('hotel/edit', ctx);
    }
});

router.get('/book/:id', isUser(), async (req, res) => {
    try {
        await req.storage.bookHotel(req.params.id, req.user._id);

        res.redirect('/hotels/details/' + req.params.id);
    } catch (err) {
        console.log(err.message);
        res.redirect('/');
    }
});

module.exports = router;