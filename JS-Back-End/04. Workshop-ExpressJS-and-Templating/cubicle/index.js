const express = require('express');
const hbs = require('express-handlebars');

start();

async function start() {
    const port = 3000;
    const app = express();

    app.engine('hbs', hbs({
        extname: '.hbs'
    }));
    app.set('view engine', 'hbs');
    
    app.listen(port, () => console.log(`Server listening on port ${port}.`))
}