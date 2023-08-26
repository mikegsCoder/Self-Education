const fs = require('fs/promises');

demo();

async function demo() {
    await fs.unlink('./package_copy.json');
} 