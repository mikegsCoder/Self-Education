const homeController = require('../controllers/homeController');
const productController = require('../controllers/productController');
const accessoryController = require('../controllers/accessoryController');
const authController = require('../controllers/authController');

module.exports = (app) => {
    app.use('/products', productController);
    app.use('/accessory', accessoryController);
    app.use('/auth', authController);
   
    app.use('/', homeController);
}