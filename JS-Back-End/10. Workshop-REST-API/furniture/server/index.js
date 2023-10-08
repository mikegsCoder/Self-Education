const express = require('express');

start();

async function start() {
    const app = express();

    app.get('/', (req, res) => res.send('It works!'));
    
    app.listen(5000, () => console.log('REST Service is running on port 5000'));
}