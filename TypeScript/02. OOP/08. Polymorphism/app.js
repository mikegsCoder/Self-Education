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
