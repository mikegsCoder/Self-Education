// ---------- classes ----------
var User1 = /** @class */ (function () {
    function User1() {
    }
    return User1;
}());
var tom = new User1();
tom.name = 'Tom';
tom.age = 36;
console.log("name: ".concat(tom.name, "  age: ").concat(tom.age)); // name: Tom  age: 36
// ---------- classes example ----------
var User2 = /** @class */ (function () {
    function User2() {
        this.name = 'Tom Smith';
        this.age = 43;
    }
    return User2;
}());
var user = new User2();
console.log("name: ".concat(user.name, "  age: ").concat(user.age)); // name: Tom Smith  age: 43
// ---------- methods ----------
var User3 = /** @class */ (function () {
    function User3() {
    }
    User3.prototype.print = function () {
        console.log("name: ".concat(this.name, "  age: ").concat(this.age));
    };
    User3.prototype.toString = function () {
        return "".concat(this.name, ": ").concat(this.age);
    };
    return User3;
}());
var john = new User3();
john.name = 'John';
john.age = 36;
john.print(); // name: John  age: 36
console.log(john.toString()); // John: 36
// ---------- constructor ----------
var User4 = /** @class */ (function () {
    function User4(userName, userAge) {
        this.name = userName;
        this.age = userAge;
    }
    User4.prototype.print = function () {
        console.log("name: ".concat(this.name, "  age: ").concat(this.age));
    };
    return User4;
}());
var george = new User4('George', 36);
george.print(); // name: George  age: 36
