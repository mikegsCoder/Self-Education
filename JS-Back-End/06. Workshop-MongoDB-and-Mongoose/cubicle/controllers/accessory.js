const Accessory = require("../models/Accessory");

module.exports = {
    createAccessory(req, res) {
        res.render('createAccessory', { title: 'Create New Accessory' });
    },
    async accessoryPost(req, res) {
        const accessory = new Accessory({
            name: req.body.name,
            description: req.body.description,
            imageUrl: req.body.imageUrl
        });

        await req.storage.createAccessory(accessory);

        res.redirect('/');
    }
};