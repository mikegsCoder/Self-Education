const fs = require('fs/promises');

console.log('before');

handleFiles();

console.log('after');

function handleFiles() {
    const promise = fs.readFile('./package.json');
    promise.then(data => console.log(data.toString()));
}