module.exports = function(err, req, res, next) {
    console.error(err.message);
    console.error(err.stack);
    res.status(500);
    res.send('500 -> Server error');
}