const { request } = require('express');
const express = require('express');
const bodyParser = require('express').urlencoded;
const expressSession = require('express-session');

const users = {};

const app = express();
app.use(bodyParser({ extended: false }));

app.listen(3000);