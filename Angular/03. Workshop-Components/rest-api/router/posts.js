const express = require('express');
const router = express.Router();
const { auth } = require('../utils');
const { postController } = require('../controllers');

router.get('/', postController.getLatestsPosts);

module.exports = router