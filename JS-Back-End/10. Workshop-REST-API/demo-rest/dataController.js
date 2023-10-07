const router = require('express').Router();

const data = {
    'a1': {
        name: 'First'
    },
    'a2': {
        name: 'Second'
    },
    'a3': {
        name: 'Third'
    }
};

router.get('/', (req, res) => {
    res.json(data);
});

module.exports = router;