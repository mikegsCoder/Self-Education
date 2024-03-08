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
var User2 = /** @class */ (function () {
    function User2(id) {
        this._id = id;
    }
    User2.prototype.getId = function () {
        return this._id;
    };
    return User2;
}());
// ---------- generic constraints ----------
function compareName1(obj1, obj2) {
    if (obj1.name === obj2.name) {
        console.log('Names are equal.');
    }
    else {
        console.log('Names are not equal.');
    }
}
var bob = { name: 'Bob' };
var sam = { name: 'Sam' };
compareName1(bob, sam); // Names are not equal.
// ---------- generic constraints example ----------
function compareName2(obj1, obj2) {
    if (obj1.name === obj2.name) {
        console.log('Names are equal.');
    }
    else {
        console.log('Names are not equal.');
    }
}
var User3 = /** @class */ (function () {
    function User3(name, age) {
        this.name = name;
        this.age = age;
    }
    return User3;
}());
var john = new User3('John', 38);
var george = new User3('George', 24);
compareName2(john, george); // Names are not equal.
var jim = { id: 1, name: 'Jim' };
var dave = { id: 2, name: 'Dave' };
compareName2(jim, dave); // Names are not equal.
var NameInfo = /** @class */ (function () {
    function NameInfo() {
    }
    NameInfo.prototype.printName = function (obj) {
        console.log("Name: ".concat(obj.name));
    };
    return NameInfo;
}());
var User4 = /** @class */ (function () {
    function User4(name, age) {
        this.name = name;
        this.age = age;
    }
    return User4;
}());
var garry = new User4('Garry', 38);
var nameInfo1 = new NameInfo();
nameInfo1.printName(garry); // Name: Garry
var peter = { id: 1, name: 'Peter' };
var nameInfo2 = new NameInfo();
nameInfo2.printName(peter); // Name: Peter
// --------- new T ----------
function userFactory(type) {
    return new type();
}
var User5 = /** @class */ (function () {
    function User5() {
        console.log("User object created.");
    }
    return User5;
}());
var user = userFactory(User5); // User object created.
