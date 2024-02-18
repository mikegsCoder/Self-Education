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
// ---------- function parameters example ----------
function sum() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    var result = 0;
    for (var i = 0; i < args.length; i++) {
        result += args[i];
    }
    return result;
}
var numbers = [1, 3, 5, 7, 9];
var num = sum.apply(void 0, numbers);
console.log(num); // 25
