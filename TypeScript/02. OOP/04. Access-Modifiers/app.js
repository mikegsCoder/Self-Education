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
