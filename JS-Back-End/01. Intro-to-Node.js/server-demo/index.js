const http = require('http');
const router = require('./router');

const server = http.createServer(requestHandler);
const port = 3000;

