const express = require('express');
const expressSession = require('express-session');
// const cookieParser = require('cookie-parser');

/*
const sessions = {};

function mySessionStorage(req, res, next) {
    let session = {};
    if (req.cookies.sessionId && sessions[req.cookies.sessionId] != undefined) {
        const id = req.cookies.sessionId;
        session = sessions[id];
        console.log('>>> Existing session ', session);
    } else {
        createSession();
    }

    req.session = session;
    
    next();
    
    function createSession() {
        const id = ('00000000' + (Math.random() * 99999999 | 0).toString(16)).slice(-8);
        sessions[id] = session;

        res.cookie('sessionId', id);
        console.log('New user generated session with Id: ', id);
        
        session.visited = 0;
    }
}

app.use(cookieParser());
app.use(mySessionStorage);
*/

const app = express();

app.use(expressSession({
    secret: 'my random secret',
    resave: false,
    saveUninitialized: true,
    cookie: { secure: false }
}));

app.get('/', (req, res) => {
    // req.session.visited++;
    // res.send(`<h1>Hello</h1><p>Your session has data ${JSON.stringify(req.session)} </p>`);
    res.send('Hello');
});

app.listen(3000);