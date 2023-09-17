const express = require('express');
const expressSession = require('express-session');

const app = express();

app.use(expressSession({
    secret: 'my random secret',
    resave: false,
    saveUninitialized: true,
    cookie: { secure: false }
}));

app.get('/', (req, res) => {
    res.send('Hello');
});

app.listen(3000);