const express = require("express");
const logger = require("./logger");

const app = express();

app.use(logger);

app.listen(3000, () => console.log("Server listening on port 3000"));
