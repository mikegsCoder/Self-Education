// ---------- tuples ----------
var user = ['Tom', 36];
console.log(user[1]); // 36
user[1] = 37;
console.log(user[1]); // 37
// ---------- tuples example ----------
for (var _i = 0, user_1 = user; _i < user_1.length; _i++) {
    var prop = user_1[_i];
    console.log(prop);
}
// ---------- tuples as function parameters ----------
function printUser(user) {
    console.log(user[0]);
    console.log(user[1]);
}
var tom = ['Tom', 36];
printUser(tom);
// Tom
// 36
// ---------- tuples as return type ----------
function createUser(name, age) {
    return [name, age];
}
var user1 = createUser('Bob', 41);
console.log(user1[0]); // Bob
console.log(user1[1]); // 41
// ---------- optional elements ----------
var bob = ['Bob', 41, true];
var john = ['John', 36];
// ---------- tuple with optional elements as function parameter ----------
function printUser1(user) {
    if (user[2] !== undefined) {
        console.log("name: ".concat(user[0], "  age: ").concat(user[1], "  isMarried: ").concat(user[2]));
    }
    else {
        console.log("name: ".concat(user[0], "  age: ").concat(user[1]));
    }
}
printUser1(bob);
printUser1(john);
// ---------- tuple example ----------
function printMarks(marks) {
    for (var _i = 0, marks_1 = marks; _i < marks_1.length; _i++) {
        var mark = marks_1[_i];
        console.log(mark);
    }
}
var math = ['Math', 5, 4, 5, 4, 4];
var physics = ['Physics', 5, 5, 5];
printMarks(math);
printMarks(physics);
// ---------- tuple example ----------
var mathTuple = ['Math', 5, 4, 5, 4, 4];
var physicsTuple = [5, 5, 5, 'Physics'];
var chemistryTuple = ['Chemistry', 3, 3, 4, 5, false];
// ---------- readonly tuple ----------
var tomReadonly = ['Tom', 36];
// tomReadonly[1] = 37; // Error!
// ---------- tuple destructuring ----------
var james = ['James', 36, false];
var username = james[0], userage = james[1], isMarried = james[2]; // decomposition
console.log(username); // James
console.log(userage); // 36
console.log(isMarried); // false
// ---------- tuple destructuring example ----------
var nameOfUser = james[0], rest = james.slice(1);
console.log(nameOfUser); // James
console.log(rest[0]); // 36
console.log(rest[1]); // false
