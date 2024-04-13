const express = require("express");
const router = express.Router();
const utils = require("../utils");

const data = {
	name: "rest-api",
	version: "1.0.0",
	description: "REST-api for back-end of Angular workshop",
	main: "index.js",
};

router.get("/", function (req, res) {
	res.send(data);
});

module.exports = router;
