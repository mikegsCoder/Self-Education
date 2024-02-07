// ---------- functions ----------
function addExample1(a, b) {
    return a + b;
}
var result1 = addExample1(1, 2); // 3
var result2 = addExample1("1", "2"); // 12
// ---------- function parameters ----------
function addExample2(a, b) {
    var result = a + b;
    console.log(result);
}
addExample2(20, 30); // 50
addExample2(10, 15); // 25
// ---------- using external variables in function ----------
var x = 1.5;
function multiplication(a) {
    var result = a * x;
    console.log(result);
}
multiplication(20); // 30
multiplication(10); // 15
// ---------- function return type ----------
function addExample3(a, b) {
    return a + b;
}
var result = addExample3(1, 2);
console.log(result); // 3
// ---------- void ----------
function addExample4(a, b) {
    console.log(a + b);
}
addExample4(10, 20); // 30
// ---------- optional parameters ----------
function getName1(firstName, lastName) {
    if (lastName)
        return firstName + ' ' + lastName;
    else
        return firstName;
}
var name1 = getName1('John', 'Smith');
console.log(name1); // John Smith
var name2 = getName1('Peter');
console.log(name2); // Peter
