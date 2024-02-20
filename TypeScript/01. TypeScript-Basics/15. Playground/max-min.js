// Write a function that takes an array of numbers and returns the max and min elements.
// ---------- solution1: ----------
function maxMin1(arr) {
    var min = Math.min.apply(Math, arr);
    var max = Math.max.apply(Math, arr);
    return [min, max];
}
var result1 = maxMin1([-2, 0, 7, 3, 5]);
console.log("The min value is ".concat(result1[0], "."));
console.log("The max value is ".concat(result1[1], "."));
