const events = require('events');

const publisher = new events.EventEmitter();

function raiseEvents(){
    console.log('before');
    publisher.emit('ping', 'Hello world!');
    console.log('after');
    publisher.emit('ping', 'Hello again!');
    publisher.emit('pong', 5, 8);
}

module.exports = {
    raiseEvents,
    publisher
}