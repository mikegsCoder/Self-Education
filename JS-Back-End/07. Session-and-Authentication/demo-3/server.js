const { request } = require('express');
const express = require('express');
const bodyParser = require('express').urlencoded;
const expressSession = require('express-session');

const users = {};

const app = express();
app.use(bodyParser({ extended: false }));
app.use(expressSession({
    secret: 'my random secret',
    resave: false,
    saveUninitialized: true,
    cookie: { secure: false }
}));

app.all('*', (req, res, next) => {
    console.log('>>> ', req.method, req.url, req.body);
    console.log('>>> Session data: ', req.session);
    next();
});

app.listen(3000);