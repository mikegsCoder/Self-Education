const express = require('express');
const hbs = require('express-handlebars');

const { init: storage } = require('./models/storage');

const { catalog } = require('./controllers/catalog');
const { notFound } = require('./controllers/notFound');

start();

async function start() {
    const port = 3000;
    const app = express();

    app.engine('hbs', hbs({
        extname: '.hbs'
    }));
    app.set('view engine', 'hbs');
    app.use('/static', express.static('static'));
    app.use('/js', express.static('js'));
    app.use(express.urlencoded({ extended: false }));
    app.use(await storage());

    app.get('/', catalog);

    app.all('*', notFound);
    
    app.listen(port, () => console.log(`Server listening on port ${port}.`))
}