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
// ---------- inheritance ----------
var Person1 = /** @class */ (function () {
    function Person1(userName) {
        this.name = userName;
    }
    Person1.prototype.print = function () {
        console.log("Name: ".concat(this.name));
    };
    return Person1;
}());
var Employee1 = /** @class */ (function (_super) {
    __extends(Employee1, _super);
    function Employee1() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Employee1.prototype.work = function () {
        console.log("".concat(this.name, " works in company ").concat(this.company, "."));
    };
    return Employee1;
}(Person1));
var bob = new Employee1('Bob');
bob.print(); // Name: Bob
bob.company = 'Microsoft';
bob.work(); // Bob works in company Microsoft.
