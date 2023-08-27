const router = require('express').Router();

const data = {
    name: 'Peter',
    age: 24
};

router.get('/catalog', (req, res) => {
    res.send('Catalog page');
});

router.post('/catalog', (req, res) => {
    res.json(data);
});

module.exports = router;