// ---------- objects ----------
var person1 = { name: 'Tom', age: 34 };
console.log(person1.name);
console.log(person1['name']);
// ---------- objects example ----------
var person2 = { name: 'John', age: 35 };
console.log(person2.name); // John
// ---------- optional properties ----------
var person3;
person3 = { name: 'Tom', age: 23 };
console.log(person3.name); // Tom
person3 = { name: 'Bob' };
console.log(person3.name); // Bob
console.log(person3.age); // undefined
// ---------- objects in functions ----------
function printUser(user) {
    console.log("name: ".concat(user.name, "  age: ").concat(user.age));
}
var tom = { age: 36, name: 'Tom' };
printUser(tom);
var bob = { name: 'Bob', age: 44, isMarried: true };
printUser(bob);
// ---------- objects as return type ----------
function defaultUser() {
    return { name: 'Tom', age: 37 };
}
var user = defaultUser();
console.log("name: ".concat(user.name, "  age: ").concat(user.age));
// ---------- operator in ----------
var user1 = { name: 'Tom', age: 23 };
var user2 = { name: 'Bob' };
function printUser1(user) {
    if ('age' in user) {
        console.log("Name: ".concat(user.name, " Age: ").concat(user.age));
    }
    else {
        console.log("Name: ".concat(user.name));
    }
}
printUser1(user1);
printUser1(user2);
