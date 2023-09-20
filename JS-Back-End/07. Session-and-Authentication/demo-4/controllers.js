module.exports = (app) => {
    app.all('*', (req, res, next) => {
        if (req.url.includes('favicon' == false)) {
            console.log('>>> ', req.method, req.url, req.body);
            console.log('>>> Session data: ', req.session);
        }
        next();
    });

    app.get('/', (req, res) => {
        let title = 'Welcome';
        if (req.session.user) {
            title = 'Welcome, ' + req.session.user.username;
        }
        res.send(layout('<p>Home Page</p>', title));
    });

    app.get('/register', (req, res) => {
        let title = 'Welcome';
        if (req.session.user) {
            title = 'Welcome, ' + req.session.user.username;
        }
        res.send(layout(`
            <form action="/register" method="POST">
                <label>Username: <input type="text" name="username"></label>
                <label>Password: <input type="password" name="password"></label>
                <label>Repeat: <input type="password" name="repass"></label>
                <input type="submit" value="Register">
            </form>
        ` , title));
    });
}

function layout(html, title) {
    return`
        <h1>${title}</h1>
        <a href="/">Home</a>
        <a href="/register">Register</a>
        <a href="/login">Login</a>
        ${html}
    `;
}