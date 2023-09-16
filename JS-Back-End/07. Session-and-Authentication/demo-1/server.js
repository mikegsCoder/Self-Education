const express = require('express');

const app = express();

const sessions = {};

function mySessionStorage(req, res, next) {
    let session = {};
    if (req.headers.cookie) {
        const id = req.headers.cookie.split('=')[1];
        if (sessions[id] == undefined) {
            console.log('>>> Invalid session cookie, generating new one.');
            createSession();
        } else {
            session = sessions[id];
            console.log('>>> Existing session ', session);
        }
    } else {
        createSession();
    }

    req.session = session;

    next();

    function createSession() {
        const id = ('00000000' + (Math.random() * 99999999 | 0).toString(16)).slice(-8);
        sessions[id] = session;
        res.setHeader('Set-Cookie', `sessionId=${id}`);
        console.log('New user generated session with Id: ', id);

        session.visited = 0;
    }
}

app.use(mySessionStorage);

app.get('/', (req, res) => {
    req.session.visited++;
    res.send(`<h1>Hello</h1><p>Your session has data ${JSON.stringify(req.session)} </p>`);
});

app.listen(3000);