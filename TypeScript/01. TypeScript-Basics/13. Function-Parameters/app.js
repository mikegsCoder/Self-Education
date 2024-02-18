// ---------- function parameters ----------
function addNumbers(firstNumber) {
    var numberArray = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        numberArray[_i - 1] = arguments[_i];
    }
    var result = firstNumber;
    for (var i = 0; i < numberArray.length; i++) {
        result += numberArray[i];
    }
    return result;
}
var num1 = addNumbers(3, 7, 8);
console.log(num1); // 18
var num2 = addNumbers(3, 7, 8, 9, 4);
console.log(num2); // 31
