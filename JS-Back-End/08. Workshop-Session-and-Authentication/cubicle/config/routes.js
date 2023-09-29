const homeController = require('../controllers/homeController');
const authController = require('../controllers/authController');

module.exports = (app) => {
    app.use('/auth', authController);
   
    app.use('/', homeController);
}