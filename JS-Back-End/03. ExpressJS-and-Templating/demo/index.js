const express = require('express');
const catalogRouter = require("./catalog");
const logger = require('./logger');
const isAdmin = require("./guard");
const fallback = require("./fallback");

const app = express();

app.use(express.static('static'));
app.use(catalogRouter);
app.use(logger);

// app.get('/', (req, res) => {
//     res.status(200);
//     res.send('Hello, Express!');
// });

// app.get('/doc', (req, res) => {
//     res.download('./demo.pdf');
// });

// using middleware:
app.get("/", logger, (req, res) => {
    res.sendFile(__dirname + "/static/index.html");
});

const data = {
    name: "Peter",
    age: 24,
};

app.post("/catalog", (req, res) => {
    res.json(data);
});

// app.get('/catalog', (req, res) => {
//     res.send('Catalog page')
// });

// app.post('/catalog', (req, res) => {
//     res.status(201)
//     res.send('Article created')
// });

// app.route('/catalog')
//     .get('/catalog', (req, res) => {
//         res.send('Catalog page');
//     })
//     .post('/catalog', (req, res) => {
//         res.status(201);
//         res.send('Article created');
//     });

app.get("/catalog/:productId", (req, res) => {
    console.log(req.params);
    res.send("Product page");
});

// app.all("/about", (req, res) => {
//     res.send("Matching all HTTP methods >>> " + req.method);
// });

app.get("/admin", isAdmin, (req, res) => {
    res.send("Admin page");
});

app.use(fallback);

app.all("*", (req, res) => {
    res.status(404);
    res.send("404 Not Found");
});

app.listen(3000, () => console.log('Server listening on port 3000'));
