const router = require("express").Router();

const { isAuth, isOwner } = require('../middlewares/guards');
const { getAll, create, update, remove } = require("../services/furniture");
const { parseError } = require('../util');
const preload = require('../middlewares/preload');

router.get("/", async (req, res) => {
    const data = await getAll();
    res.json(data);
});

router.post("/", isAuth(), async (req, res) => {
    const data = {
        make: req.body.make,
        model: req.body.model,
        year: Number(req.body.year),
        description: req.body.description,
        price: Number(req.body.price),
        img: req.body.img,
        material: req.body.material,
        owner: req.user._id
    };

    try {
        const result = await create(data);
        
        res.status(201).json(result);
    } catch (err) {
        const message = parseError(err); 
        res.status(err.status || 400).json({ message });       
    }
});

router.get('/:id', preload(), async (req, res) => {
    const item = req.data.toObject();
    item._ownerId = item.owner;

    res.json(item);
});

router.put('/:id', isAuth(), preload(), isOwner(), async (req, res) => {
    const updated = {
        make: req.body.make,
        model: req.body.model,
        year: Number(req.body.year),
        description: req.body.description,
        price: Number(req.body.price),
        img: req.body.img,
        material: req.body.material
    };

    try {
        const result = await update(req.data, updated);
        
        res.json(result);
    } catch (err) {
        const message = parseError(err); 
        res.status(err.status || 400).json({ message });       
    }
});

router.delete('/:id', isAuth(), preload(), isOwner(), async (req, res) => {
    try {
        await remove(req.params.id);
        res.status(204).end();
    } catch (err) {
        res.status(err.status || 400).json({ message: err.message });
    }
});

module.exports = router;
