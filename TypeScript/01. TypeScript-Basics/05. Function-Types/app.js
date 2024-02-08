// ---------- void ----------
function hello() {
    console.log("Hello TypeScript!");
};
var message = hello;
message();
// ---------- number ----------
function sumFunction(x, y) {
    return x + y;
};
function subtractFunction(a, b) {
    return a - b;
};
var op;
op = sumFunction;
console.log(op(2, 4)); // 6
op = subtractFunction;
console.log(op(6, 4)); // 2
// ---------- functions as parameters to another functions ----------
function sum(x, y) {
    return x + y;
};
function multiply(a, b) {
    return a * b;
};
function mathOp(x, y, op) {
    return op(x, y);
}
console.log(mathOp(10, 20, sum)); // 30 
console.log(mathOp(10, 20, multiply)); // 200 
function mathOp1(x, y, op) {
    return op(x, y);
}
var sum1 = function (x, y) {
    return x + y;
};
console.log(mathOp1(10, 20, sum1)); // 30
// ---------- arrow functions: ----------
var sum2 = function (x, y) { return x + y; };
var result = sum2(10, 20); // 30
console.log(result);
// ----------
var square = function (x) { return x * x; };
var hello1 = function () { return "hello world!"; };
console.log(square(4)); // 16
console.log(hello1()); // hello world!
// ----------
function mathOp2(x, y, operation) {
    var result = operation(x, y);
    return result;
}
console.log(mathOp2(10, 20, function (x, y) { return x + y; })); // 30 
console.log(mathOp2(10, 20, function (x, y) { return x * y; })); // 200
