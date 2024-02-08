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
