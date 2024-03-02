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
var p = { x: 10, y: 20 };
console.log(p); // { x: 10, y: 20 }
var employee3 = {
    id: 1,
    name: 'Alice',
    sayWords: function (words) {
        console.log("".concat(this.name, " says \"").concat(words, "\""));
    }
};
employee3.sayWords('Hi, how are you?'); // Alice says "Hi, how are you?"
var User = /** @class */ (function () {
    function User(userId, userName, userAge) {
        this.id = userId;
        this.name = userName;
        this.age = userAge;
    }
    User.prototype.getFullName = function (surname) {
        return this.name + ' ' + surname;
    };
    return User;
}());
var tom = new User(1, 'Tom', 35);
console.log(tom.getFullName('Simpson')); // Tom Simpson
var employee4 = {
    id: 1,
    name: 'Alice',
    age: 31
};
function printUser4(user) {
    console.log("id: ".concat(user.id, "  name: ").concat(user.name, "  age: ").concat(user.age));
}
printUser4(employee4); // id: 1  name: Alice  age: 31
