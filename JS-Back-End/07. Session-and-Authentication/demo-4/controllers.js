module.exports = (app) => {
    app.all('*', (req, res, next) => {
        if (req.url.includes('favicon' == false)) {
            console.log('>>> ', req.method, req.url, req.body);
            console.log('>>> Session data: ', req.session);
        }
        next();
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