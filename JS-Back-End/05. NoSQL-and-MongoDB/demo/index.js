const mongoose = require('mongoose');

const Cat = require('./models/Cat');

async function start() {
    const connectionStr = 'mongodb://localhost:27017/testdb';

    const client = await mongoose.connect(connectionStr, {
        useNewUrlParser: true,
        useUnifiedTopology: true,
    });

    console.log('Database connected.');

    // Cats collection:
    try {
        const someCat = new Cat({
            name: 'fluffy',
            color: 'White'
        });
        await someCat.save();
    } catch (err) {
        console.log('Caught the error.');
        console.log('>>>', err.message);
    }
}

start();
