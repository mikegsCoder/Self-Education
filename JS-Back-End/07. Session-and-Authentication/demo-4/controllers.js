module.exports = (app) => {
    app.all('*', (req, res, next) => {
        if (req.url.includes('favicon' == false)) {
            console.log('>>> ', req.method, req.url, req.body);
            console.log('>>> Session data: ', req.session);
        }
        next();
    });
}
