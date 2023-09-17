const { request } = require('express');
const express = require('express');
const bodyParser = require('express').urlencoded;
const expressSession = require('express-session');

const users = {};

const app = express();

app.listen(3000);