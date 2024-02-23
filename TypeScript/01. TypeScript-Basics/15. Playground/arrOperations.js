/*
    You will be given an array of integers on the first line of input.
    You will be receiving operations you have to apply on the array until you receive the "End" command.
    The possible commands are:
     - Add {number} – add number at the end.
     - Insert {number} {index} – insert number at given index.
     - Remove {index} – remove at index.
     - Shift left {count} – first number becomes last ‘count’ times.
     - Shift right {count} – last number becomes first ‘count’ times.
    If index is outside of the bounds of the array print "Invalid index".
*/
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
function operations(args) {
    var arr = [];
    if (Array.isArray(args)) {
        arr.push.apply(arr, args);
    }
    function modify(command, x, y) {
        var num = x !== null && x !== void 0 ? x : null;
        var index = y !== null && y !== void 0 ? y : null;
        function verifyIndex(i) {
            if (i !== null && 0 <= i && i <= arr.length - 1) {
                return i;
            }
            else if (i !== null && (0 > i || i > arr.length - 1)) {
                console.log('Invalid index');
            }
            return null;
        }
        switch (command) {
            case "Add":
                if (num) {
                    arr.push(num);
                }
                break;
            case "Insert":
                if (num) {
                    var i = verifyIndex(index);
                    if (i !== null) {
                        arr = __spreadArray(__spreadArray(__spreadArray([], arr.slice(0, i), true), [num], false), arr.slice(i), true);
                    }
                }
                break;
            case "Remove":
                if (num !== null && num >= 0) {
                    var i = verifyIndex(num);
                    if (i !== null) {
                        arr = __spreadArray(__spreadArray([], arr.slice(0, i), true), arr.slice(i + 1), true);
                    }
                }
                break;
            case "Shift left":
                if (num) {
                    arr = __spreadArray(__spreadArray([], arr.slice(num, arr.length), true), arr.slice(0, num), true);
                }
                break;
            case "Shift right":
                if (num) {
                    arr = __spreadArray(__spreadArray([], arr.slice(arr.length - num, arr.length), true), arr.slice(0, arr.length - num), true);
                }
                break;
            case "End":
                console.table(arr);
                break;
            default:
                break;
        }
    }
    return modify;
}
var test = operations([1, 2, 3,]);
test("Add", 4);
test("Add", 5);
test("Add", 6);
test("Add", 7);
test("End");
test("Insert", 666, -1);
test("Insert", 200, 1);
test("Insert", 300, 5);
test("Insert", 400, 8);
test("Insert", 100, 0);
test("End");
test("Remove", 999);
test("Remove", 9);
test("Remove", 6);
test("Remove", 2);
test("Remove", 0);
test("End");
test("Shift left", 2);
test("End");
test("Shift right", 3);
test("End");
