const fs = require('fs/promises');

demo();

async function demo() {
    const files = await fs.readdir('.');
    console.log(files);
}