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
        req.storage = {
            getAll,
            getById
        };

        next();
    };
}

async function getAll(query) {
    let cubes = Object
        .entries(data)
        .map(([id, v]) => Object.assign({}, { id }, v));

    if (query.search) {
        cubes = cubes.filter(c => c.name.toLowerCase().includes(query.search.toLowerCase()));
    } 

    if (query.from) {
        cubes = cubes.filter(c => c.difficulty >= Number(query.from));
    }

    if (query.to) {
        cubes = cubes.filter(c => c.difficulty <= Number(query.to));
    }

    return cubes;
}

async function getById(id) {
    const cube = data[id];

    if (cube) {
        return Object.assign({}, {id}, cube);
    } else {
        return undefined;
    }
}

module.exports = {
    init,
    getAll,
    getById
};