const { catalog } = require('../controllers/catalog');
const { about } = require('../controllers/about');
const { details, attach, attachPost } = require('../controllers/details');
const { create, post: createPost } = require('../controllers/create');
const { edit, post: editPost } = require('../controllers/edit');
const { createAccessory, accessoryPost } = require('../controllers/accessory');
const { notFound } = require('../controllers/notFound');

module.exports = (app) => {
    app.get('/', catalog);
    app.get('/about', about);
    app.get('/details/:id', details);
    app.get('/create', create);
    app.post('/create', createPost);

    app.get('/edit/:id', edit);
    app.post('/edit/:id', editPost);

    app.get('/accessory/create', createAccessory);
    app.post('/accessory/create', accessoryPost);

    app.all('*', notFound);
}