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
// ---------- public ----------
var Person1 = /** @class */ (function () {
    function Person1() {
    }
    return Person1;
}());
// ---------- private ----------
var Person2 = /** @class */ (function () {
    function Person2(name, age) {
        this._name = name;
        this._year = this.setYear(age);
    }
    Person2.prototype.print = function () {
        console.log("Name: ".concat(this._name, "  Year of birth: ").concat(this._year));
    };
    Person2.prototype.setYear = function (age) {
        return new Date().getFullYear() - age;
    };
    return Person2;
}());
var tom = new Person2('Tom', 24);
tom.print(); // Name: Tom  Year of birth: 2000
// console.log(tom._name);  // Error!
// tom.setYear(45);         // Error!
// ---------- protected ----------
var Person3 = /** @class */ (function () {
    function Person3(name, age) {
        this.name = name;
        this.year = this.setYear(age);
    }
    Person3.prototype.printPerson = function () {
        console.log("Name: ".concat(this.name, "  Year of birth: ").concat(this.year));
    };
    Person3.prototype.setYear = function (age) {
        return new Date().getFullYear() - age;
    };
    return Person3;
}());
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(name, age, company) {
        var _this = _super.call(this, name, age) || this;
        _this.company = company;
        return _this;
    }
    Employee.prototype.printEmployee = function () {
        // console.log("Year: " + this.year);   // field year is inaccessible, because it is private
        // setYear(25);                         // method setYear is inaccessible, because it is private
        this.printPerson(); // method printPerson is accessible, because it is protected
        console.log("Company: ".concat(this.company));
    };
    return Employee;
}(Person3));
var sam = new Employee('Sam', 31, 'Microsoft');
sam.printEmployee();
/*
Name: Sam  Year of birth: 1993
Company: Microsoft
*/
// ---------- set access modifiers in constructor ----------
var Person4 = /** @class */ (function () {
    function Person4(name, age) {
        this.name = name;
        this.age = age;
    }
    Person4.prototype.printPerson = function () {
        console.log("Name: ".concat(this.name, "  Age: ").concat(this.age));
    };
    return Person4;
}());
