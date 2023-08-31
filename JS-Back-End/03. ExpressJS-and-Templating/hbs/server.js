const express = require('express');
const { engine } = require('express-handlebars');
// const bodyParser = require('body-parser').urlencoded({
//     extended: true
// });

const storage = require('./util/storage');
const home = require('./controllers/home');
const catalog = require('./controllers/catalog');

async function start() {
    const port = 3000;
    const app = express();

    //app.use(bodyParser);
    app.use(express.urlencoded({extended: true}));

    app.engine(
        ".hbs",
        engine({
            extname: ".hbs",
        })
    );

    app.set("view engine", ".hbs");

    app.use(await storage());

    app.get('/', home);
    
    app.use('/catalog', catalog);

    app.listen(port, () => console.log(`Server listening on port ${port}.`));
}

start();