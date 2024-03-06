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
