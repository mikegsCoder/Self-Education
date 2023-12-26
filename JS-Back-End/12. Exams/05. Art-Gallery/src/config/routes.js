const homeController = require('../controllers/homeController');
const authController = require('../controllers/authController');
const itemController = require('../controllers/itemController');

module.exports = (app) => {
    app.use('/', homeController);
    app.use('/auth', authController);
    app.use('/item', itemController);
};