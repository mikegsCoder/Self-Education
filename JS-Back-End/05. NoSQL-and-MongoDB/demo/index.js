const mongoose = require("mongoose");

async function start() {
    const connectionStr = "mongodb://localhost:27017/testdb";

    const client = await mongoose.connect(connectionStr, {
        useNewUrlParser: true,
        useUnifiedTopology: true,
    });

    console.log("Database connected.");
}

start();
