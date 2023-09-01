const fs = require('fs/promises');
const uniqid = require('uniqid');

let data = {};

async function init() {
    try {
        data = JSON.parse(await fs.readFile('./models/data.json'));
    } catch (err) {
        console.error('Error reading database.');
    };

    return (req, res, next) => {
        next();
    };
}

module.exports = {
    init
};