const { request } = require('express');
const express = require('express');
const bodyParser = require('express').urlencoded;
const expressSession = require('express-session');
// const bcrypt = require('bcrypt');

const auth = require('./auth');
const routes = require('./controllers');

const app = express();

app.use(bodyParser({ extended: false }));
app.use(expressSession({
    secret: 'my random secret',
    resave: false,
    saveUninitialized: true,
    cookie: { secure: false }
}));
app.use(auth);

routes(app);

app.post('/register', async (req, res) => {
    await req.register(req.body.username, req.body.password);
    res.redirect('/login');
});

app.listen(3000);