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
