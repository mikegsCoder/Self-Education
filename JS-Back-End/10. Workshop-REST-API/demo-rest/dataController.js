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

router.get('/:id', (req, res) => {
    res.json(data[req.params.id]);
});

router.put('/:id', (req, res) => {
    data[req.params.id] = req.body;
    res.status(202).json(data[req.params.id]);
});

router.patch('/:id', (req, res) => {
    const item = data[req.params.id];
    Object.assign(item, req.body);
    data[req.params.id] = item;
    res.status(202).json(item);
});

router.delete('/:id', (req, res) => {
    delete data[req.params.id];
    res.status(204).end();
});

module.exports = router;