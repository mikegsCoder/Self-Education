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
