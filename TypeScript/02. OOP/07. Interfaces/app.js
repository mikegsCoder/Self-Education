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
