const jwt = require('jsonwebtoken');

const payload = { message: 'Hi!' };
const secret = 'my-secret-key';

const token = jwt.sign(payload, secret, { expiresIn: '2d' })

console.log(token);

const myToken = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJtZXNzYWdlIjoiSGkhIiwiaWF0IjoxNjc1OTQyNTU4LCJleHAiOjE2NzYxMTUzNTh9.0GXjmIo1ZAjTXu3tFEU8iYhlPDt13M9J5ngbSNWwlws';

console.log(jwt.decode(myToken));
console.log(jwt.verify(myToken, secret));