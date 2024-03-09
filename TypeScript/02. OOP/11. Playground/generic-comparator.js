/*
Create a generic class that has as a property an array of generic
type. Create a compare(comparator) method that takes an argument of
any type. Iterate through the array and compare each element of the
array to the comparator and return how many times the comparator is
matched.
*/
// ---------- solution 1 ----------
var CompareElements1 = /** @class */ (function () {
    function CompareElements1(arr) {
        this._arr = arr;
    }
    CompareElements1.prototype.compare = function (item) {
        var counter = 0;
        this._arr.forEach(function (x) {
            if (x === item) {
                counter++;
            }
        });
        return counter;
    };
    return CompareElements1;
}());
var c1 = new CompareElements1(['a', 'b', 'ab', 'abc', 'cba', 'b']);
console.log(c1.compare('b')); // 2
var d1 = new CompareElements1([1, 2, 3, 4, 5, 1, 1]);
console.log(d1.compare(1)); // 3
// ---------- solution 2 ----------
var CompareElements2 = /** @class */ (function () {
    function CompareElements2(arr) {
        var _this = this;
        this.compare = function (item) { return _this._arr.filter(function (x) { return x === item; }).length; };
        this._arr = arr;
    }
    return CompareElements2;
}());
var c2 = new CompareElements2(['a', 'b', 'ab', 'abc', 'cba', 'b']);
console.log(c1.compare('b')); // 2
var d2 = new CompareElements2([1, 2, 3, 4, 5, 1, 1]);
console.log(d1.compare(1)); // 3
