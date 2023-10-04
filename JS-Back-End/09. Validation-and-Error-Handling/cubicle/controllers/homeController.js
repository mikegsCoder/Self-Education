const { Router } = require('express');
const asyncWrapper = require('../util/asyncWrapper');

const router = Router();

router.get('/', (req, res) => res.redirect('/products'));

router.get('/about', asyncWrapper( async (req, res) => {
    // throw new Error('Test Error');
    res.render('about', {title: 'About Page'});
}));

router.all('*', (req, res) => {
    res.render('404', {title: 'Page Not Found'});
});

module.exports = router;