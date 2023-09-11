const express = require('express');
const expressConfig = require('./config/express');

start();

async function start() {
    const port = 3000;
    const app = express();

    expressConfig(app);
    
    app.listen(port, () => console.log(`Server listening on port ${port}.`))
}