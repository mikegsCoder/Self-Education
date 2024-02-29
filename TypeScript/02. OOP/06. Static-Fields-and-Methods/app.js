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
// ---------- static fields and methods ----------
var Person1 = /** @class */ (function () {
    function Person1(name, age) {
        this.name = name;
        this.age = age;
    }
    Person1.calculateYears = function (age) {
        return Person1.retirementAge - age;
        // return Person1.retirementAge - this.age; // Error! 
    };
    Person1.retirementAge = 70;
    return Person1;
}());
var tom = new Person1('Tom', 36);
var years = Person1.calculateYears(36);
console.log(Person1.retirementAge); // 70
console.log(years); // 34
// ---------- access modifiers ----------
var Person2 = /** @class */ (function () {
    function Person2(name, age) {
        this.name = name;
        this.age = age;
    }
    Person2.calculateYears = function (age) {
        return Person2.retirementAge - age;
    };
    Person2.retirementAge = 70;
    return Person2;
}());
// ---------- inheritance ----------
var Person3 = /** @class */ (function () {
    function Person3(name, age) {
        this.name = name;
        this.age = age;
    }
    Person3.calculateYears = function (age) {
        return Person3.retirementAge - age;
    };
    Person3.retirementAge = 70;
    return Person3;
}());
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return Employee;
}(Person3));
var years3 = Employee.calculateYears(36); // 34
console.log(Employee.retirementAge); // 70
