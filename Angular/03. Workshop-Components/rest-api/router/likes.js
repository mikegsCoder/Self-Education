const express = require('express');
const router = express.Router();
const { auth } = require('../utils');
const { postController } = require('../controllers');

router.put('/:postId', auth(), postController.like);

module.exports = router
