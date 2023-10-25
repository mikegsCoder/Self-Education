const homeController = require('../controllers/homeController');
const authController = require('../controllers/authController');
const hotelController = require('../controllers/hotelController');
const userController = require('../controllers/userController');

module.exports = (app) => {
    app.use('/', homeController);
    app.use('/auth', authController);
    app.use('/hotels', hotelController);
    app.use('/user', userController);
};