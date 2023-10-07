const express = require('express');

const dataController = require('./dataController');

const app = express();

app.use((req, res, next) => {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, PATCH, DELETE');
    res.setHeader('Access-Control-Allow-Headers', 'Content-Type');

    next();
});

app.use(express.json());

app.use('/api', dataController);

app.get('/', (req, res) => {
    res.send('REST service operational. Send requests on /api');
});

app.listen(5000, () => console.log('Server listening on port 5000.'));