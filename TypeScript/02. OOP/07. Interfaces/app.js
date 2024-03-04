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
var Car = /** @class */ (function () {
    function Car() {
    }
    Car.prototype.move = function () {
        console.log("Car moves at speed " + this.speed + " km/h.");
    };
    Car.prototype.fill = function () {
        console.log("Fill car with fuel.");
    };
    return Car;
}());
var auto = new Car();
auto.speed = 60;
auto.fill(); // Fill car with fuel.
auto.move(); // Car moves at speed 60 km/h.
var simpleBuilder = function (name, surname) {
    return 'Mr. ' + name + ' ' + surname;
};
var fullName = simpleBuilder('Bob', 'Simpson');
console.log(fullName); // Mr. Bob Simpson
var phones;
phones = ['iPhone 7', 'HTC 10', 'HP Elite x3'];
var myPhone = phones[0];
console.log(myPhone); // iPhone 7
var colors = {};
colors['red'] = '#ff0000';
colors['green'] = '#00ff00';
colors['blue'] = '#0000ff';
console.log(colors['red']); // #ff0000
function personBuilder() {
    var person = function (name, surname) {
        person.fullName = name + ' ' + surname;
    };
    person.authenticate = function () {
        console.log(person.fullName + ' has personal password ' + person.password);
    };
    return person;
}
var person = personBuilder();
person('Tom', 'Simpson');
person.password = 'qwerty';
person.authenticate(); // Tom Simpson has personal password qwerty
