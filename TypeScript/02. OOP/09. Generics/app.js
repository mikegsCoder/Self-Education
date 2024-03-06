// ---------- generics ----------
function getId(id) {
    return id;
}
var result1 = getId(5);
console.log(result1); // 5
var result2 = getId('abc');
console.log(result2); // abc
// ---------- generic array ----------
function getString(args) {
    return args.join(', ');
}
var result3 = getString([1, 2, 34, 5]);
console.log(result3); // 1, 2, 34, 5
// ---------- generic class ----------
var User1 = /** @class */ (function () {
    function User1(id) {
        this._id = id;
    }
    User1.prototype.getId = function () {
        return this._id;
    };
    return User1;
}());
var tom = new User1(3);
console.log(tom.getId()); // 3
// tom = new User1<string>("asd");  // Error!
var alice = new User1('xyz');
console.log(alice.getId()); // xyz
