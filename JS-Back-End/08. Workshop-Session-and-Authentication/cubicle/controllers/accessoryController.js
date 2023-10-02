const { Router } = require('express');

const router = Router();

router.get('/create', (req, res) => {
    res.render('createAccessory', { title: 'Create New Accessory' });
});

module.exports = router;