const mongoose = require('mongoose');

const Cat = require('./models/Cat');
const Person = require("./models/Person");

async function start() {
    const connectionStr = 'mongodb://localhost:27017/testdb';

    const client = await mongoose.connect(connectionStr, {
        useNewUrlParser: true,
        useUnifiedTopology: true,
    });

    console.log('Database connected.');

    // Cats collection:
    // try {
    //     const someCat = new Cat({
    //         name: 'fluffy',
    //         color: 'White'
    //     });
    //     await someCat.save();
    // } catch (err) {
    //     console.log('Caught the error.');
    //     console.log('>>>', err.message);
    // }

    // People collection:
    // try {
    //     const person = new Person({
    //         age: -5
    //     });
    //     await person.save();
    // } catch (err) {
    //     console.log('Caught the error.');
    //     console.log('>>>', err.message);
    // }

    // find:
    // const data = await Person.find({ firstName: 'John' });
    // const data = await Person.find({ _id: '63deaa5c5cb8e74b3d9eda9f' }); // returns array
    // const data = await Person.findById('63deaa5c5cb8e74b3d9eda9f'); // returns object
    // const data = await Person.find({ lastName: /s/i }); // search by regex
    // const data = await Person.find({ age: { $gt: 30 } }); // age > 30
    // const data = await Person.find({ age: { $gte: 30 } }); // age >= 30
    // const data = await Person.find({ age: { $lt: 30 } }); // age < 30
    // const data = await Person.find({ age: { $lte: 30 } }); // age <= 30
    // console.log(data);

    // update:
    await Person.findByIdAndUpdate('63deaa5c5cb8e74b3d9eda9f', { $set: { lastName: 'Ryan', age: 31 } });
    await Person.updateOne({ firstName: 'John' }, { $set: { lastName: 'Stavros', age: 44 } });
    console.log(await Person.find({}));
}

start();
