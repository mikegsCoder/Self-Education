/*
Create a Family class with public property family which must be set
to empty array through the constructor.
The class must support 2 methods: a method for adding members to the
family array – addNewMember(member) which is tuple of string and number
which represents the name and the age of each member and a method
oldestMember() which returns the oldest member in the family in the
following format: "The oldest member is {name} and he is {age} years old."
*/
var Family1 = /** @class */ (function () {
    function Family1(family) {
        if (family === void 0) { family = []; }
        this.family = family;
    }
    Family1.prototype.addNewMember = function (value) {
        this.family.push(value);
    };
    Family1.prototype.oldestMember = function () {
        var oldestMemberName = '';
        var oldestAge = -Infinity;
        this.family.forEach(function (_a) {
            var name = _a[0], age = _a[1];
            if (oldestAge < age) {
                oldestMemberName = name;
                oldestAge = age;
            }
        });
        return "The oldest member is ".concat(oldestMemberName, " and he is ").concat(oldestAge, " years old.");
    };
    return Family1;
}());
var family1 = new Family1();
family1.addNewMember(['Ivan', 13]);
family1.addNewMember(['Todor', 45]);
family1.addNewMember(['Georgi', 37]);
family1.addNewMember(['Viktor', 30]);
console.log(family1.oldestMember()); // The oldest member is Todor and he is 45 years old.
