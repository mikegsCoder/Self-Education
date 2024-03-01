var employee1 = {
    id: 1,
    name: 'Tom'
};
console.log('id: ', employee1.id);
console.log('name: ', employee1.name);
// ---------- interfaces as method and function parameters ----------
var employee2 = {
    id: 2,
    name: 'Alice'
};
function printUser(user) {
    console.log('id: ', user.id);
    console.log('name: ', user.name);
}
printUser(employee2);
// id:  2
// name:  Alice
// ---------- interfaces as return type ----------
function buildUser(userId, userName) {
    return { id: userId, name: userName };
}
var newUser = buildUser(3, 'Bill');
console.log('id: ', newUser.id); // id:  3
console.log('name: ', newUser.name); // name:  Bill
var employee = {
    id: 1,
    name: 'Alice',
    age: 23
};
var manager = {
    id: 2,
    name: 'Tom'
};
