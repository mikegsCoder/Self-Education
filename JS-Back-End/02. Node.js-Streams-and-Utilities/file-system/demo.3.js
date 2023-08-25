const fs = require('fs/promises');

console.log('before');

handleFiles();

console.log('after');

async function handleFiles() {
    const data = await fs.readFile('./package.json');
    console.log(data.toString());
}