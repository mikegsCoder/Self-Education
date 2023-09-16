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
        // some implementation here
    }
}

app.listen(3000);