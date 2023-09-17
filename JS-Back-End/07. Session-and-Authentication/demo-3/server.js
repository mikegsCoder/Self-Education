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

app.listen(3000);