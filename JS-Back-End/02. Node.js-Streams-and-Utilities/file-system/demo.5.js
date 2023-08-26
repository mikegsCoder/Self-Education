const fs = require('fs/promises');

demo();

async function demo() {
    await fs.mkdir('./demoDir');
}