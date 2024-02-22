// Write a program, which reads an array of numbers and commands, to manipulate the array as follows:
// - Delete {element} – delete all elements in the array, which are equal to the given element.
// - Insert {element} {position} – insert an element at the given position.
// You should stop the program when you receive the command "end". Print the numbers in the array separated by ', '.
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
// ---------- solution ----------
function arrMod(input) {
    var _a = input.split('\n'), arr = _a[0], ops = _a.slice(1);
    var nums = arr.split(' ').map(function (x) { return Number(x); });
    ops.forEach(function (currentOp) {
        var _a = currentOp.split(' '), operation = _a[0], value = _a[1], _b = _a[2], index = _b === void 0 ? nums.length : _b;
        if (operation.toLowerCase() === 'delete') {
            nums = nums.filter(function (x) { return x !== Number(value); });
        }
        else if (operation.toLowerCase() === "insert") {
            nums = __spreadArray(__spreadArray(__spreadArray([], nums.slice(0, Number(index)), true), [Number(value)], false), nums.slice(Number(index)), true);
        }
    });
    return nums.map(function (x) { return x.toString(); }).join(', ');
}
var result1 = arrMod('5 3 8 10 34 7 546 32\nDelete 5\nInsert 10 1\nDelete 7\nend');
var result2 = arrMod('45 1 27 -5 6 74\nInsert 50 2\nInsert 11 5\nDelete 4\nend');
console.table(result1);
console.table(result2);
