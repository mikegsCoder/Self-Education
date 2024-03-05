var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// ---------- polymorphism ----------
var Person1 = /** @class */ (function () {
    function Person1(userName) {
        this.name = userName;
    }
    return Person1;
}());
var Employee1 = /** @class */ (function (_super) {
    __extends(Employee1, _super);
    function Employee1(userName, company) {
        var _this = _super.call(this, userName) || this;
        _this.company = company;
        return _this;
    }
    return Employee1;
}(Person1));
function printPerson(user) {
    console.log("Person ".concat(user.name));
}
function personFactory(userName) {
    return new Employee1(userName, 'default');
}
var user1 = new Employee1('Tom', 'Microsoft');
printPerson(user1); // Person Tom
var user2 = personFactory('Bob');
printPerson(user2); // Person Bob
// ---------- polymorphism example ----------
var Person2 = /** @class */ (function () {
    function Person2(userName) {
        this.name = userName;
    }
    return Person2;
}());
var Employee2 = /** @class */ (function (_super) {
    __extends(Employee2, _super);
    function Employee2(userName, company) {
        var _this = _super.call(this, userName) || this;
        _this.company = company;
        return _this;
    }
    return Employee2;
}(Person2));
var user3 = new Employee2('Tom', 'Microsoft');
// console.log(user3.company);   // Error!
var user3Employee1 = user3; // type conversion
console.log(user3Employee1.company); // Microsoft
var user3Employee2 = user3; // type conversion
console.log(user3Employee2.company); // Microsoft
var Person3 = /** @class */ (function () {
    function Person3(userName) {
        this.name = userName;
    }
    return Person3;
}());
var Employee3 = /** @class */ (function (_super) {
    __extends(Employee3, _super);
    function Employee3(userName, company) {
        var _this = _super.call(this, userName) || this;
        _this.company = company;
        return _this;
    }
    return Employee3;
}(Person3));
function printPerson1(user) {
    console.log("IPerson ".concat(user.name));
}
var tom = new Employee3('Tom', 'Microsoft');
printPerson1(tom); // IPerson Tom
// ---------- instanceOf ----------
var bob = new Employee3('Bob', 'Microsoft');
if (bob instanceof Person3) {
    console.log('Bob is a Person');
}
else {
    console.log('Bob is not a Person');
}
// Bob is a Person
