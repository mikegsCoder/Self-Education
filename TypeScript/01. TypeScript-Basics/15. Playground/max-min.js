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
// ---------- solution2: ----------
function maxMin2(arr) {
    var min = arr[0];
    var max = arr[0];
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] < min) {
            min = arr[i];
        }
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return [min, max];
}
var result2 = maxMin2([-2, 0, 7, 3, 5]);
console.log("The min value is ".concat(result2[0], "."));
console.log("The max value is ".concat(result2[1], "."));
