// ---------- arrays ----------
var list = [10, 20, 30];
var colors = ['red', 'green', 'blue'];
console.log(list[0]); // 10
console.log(colors[1]); // green
// ---------- arrays example ----------
var names = ['Tom', 'Bob', 'Alice'];
console.log(names[1]); // Bob
// ---------- ReadonlyArray ----------
var people1 = ['Tom', 'Bob', 'Sam'];
/*
people1[1] = 'Kate';   // Error!
people1.push('Kate');  // Error!
people1.pop();         // Error!
*/
// ---------- ReadonlyArray example ----------
function printUsers(users) {
    for (var _i = 0, users_1 = users; _i < users_1.length; _i++) {
        var user = users_1[_i];
        console.log(user);
    }
}
function usersToString(users) {
    return users.join(', ');
}
var people2 = ['Tom', 'Bob', 'Sam'];
printUsers(people2);
console.log(usersToString(people2));
// ---------- array decomposition ----------
var people3 = ['Tom', 'Bob', 'Sam'];
var first = people3[0], second = people3[1], third = people3[2];
console.log(first); // Tom
console.log(second); // Bob
console.log(third); // Sam
// ---------- array decomposition example ----------
var people4 = ['Tom', 'Bob', 'Sam'];
var one = people4[0], rest = people4.slice(1);
console.log(one); // Tom
console.log(rest[0]); // Bob
console.log(rest[1]); // Sam
// ---------- array decomposition example ----------
var people5 = ['Tom', 'Bob', 'Sam', 'Kate'];
var two = people5[1], four = people5[3]; // we miss first and third elements
console.log(two); // Bob
console.log(four); // Kate
