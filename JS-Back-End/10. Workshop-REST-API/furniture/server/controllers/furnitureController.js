const router = require("express").Router();

const { getAll, create, update, remove } = require("../services/furniture");

router.get("/", async (req, res) => {
    const data = await getAll();
    res.json(data);
});

module.exports = router;
