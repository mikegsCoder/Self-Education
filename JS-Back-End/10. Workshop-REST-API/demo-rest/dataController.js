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

router.post('/', (req, res) => {
    const id = 'a' + (Math.random() * 1000 | 0);
    data[id] = req.body;
    res.status(201).json({ _id: id });
});

module.exports = router;