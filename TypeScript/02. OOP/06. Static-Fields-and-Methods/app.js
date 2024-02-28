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
