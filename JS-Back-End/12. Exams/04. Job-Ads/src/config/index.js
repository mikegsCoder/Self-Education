const itemName = 'Ad'

module.exports = {
    ITEM: itemName,
    DB_CONNECTION_STRING: `mongodb://0.0.0.0:27017/${itemName.toLowerCase()}`,
    PORT: 3000,
    TOKEN_SECRET: 'this is my secret',
    COOKIE_NAME: 'SESSION_TOKEN'
};