const bcrypt = require('bcrypt');

const users = {};

module.exports = (req, res, next) => {
    req.register = async (username, password) => {
        const id = ('00000000' + (Math.random() * 99999999 | 0).toString(16)).slice(-8);

        const hashedPassword = await bcrypt.hash(password, 8);

        users[id] = {
            username: req.body.username,
            hashedPassword
        };

        console.log('New user', users);
    };

    req.login = async (username, password) => {
        const user = Object.entries(users).find(([id, u]) => u.username == username);
        
        console.log('Checking password', password, 'for user', user);
    
        // const passwordsMatch = await bcrypt.compare(password, user[1].hashedPassword);
    
        if (user && await bcrypt.compare(password, user[1].hashedPassword)) {
            req.session.user = {
                _id: user[1].id,
                username
            };

            return true;
        } else {
            return false;
        }
    }
    
    next();
};