const fs = require('fs/promises');

demo();

async function demo() {
    await fs.rmdir('./demoDir');
}