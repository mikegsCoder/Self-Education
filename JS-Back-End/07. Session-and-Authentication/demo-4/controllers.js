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