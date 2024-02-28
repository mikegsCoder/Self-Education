// ---------- get and set ----------
var Person1 = /** @class */ (function () {
    function Person1() {
    }
    Object.defineProperty(Person1.prototype, "age", {
        get: function () {
            return this._age;
        },
        set: function (n) {
            if (n < 0 || n > 110) {
                console.log("Invalid age!");
            }
            else {
                this._age = n;
            }
        },
        enumerable: false,
        configurable: true
    });
    return Person1;
}());
var tom = new Person1();
tom.name = 'Tom';
tom.age = 36;
console.log(tom.age); // 36
tom.age = -1243; // Недопустимый возраст!   
console.log(tom.age); // 36 
// ---------- get and set ----------
