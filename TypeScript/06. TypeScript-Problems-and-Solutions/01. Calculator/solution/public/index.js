// tsc && node .\public\index.js
function calc(firstNum, action, secondNum) {
    const calc = {
        '+': (firstNum + secondNum).toFixed(2),
        '-': (firstNum - secondNum).toFixed(2),
        '*': (firstNum * secondNum).toFixed(2),
        '/': (firstNum / secondNum).toFixed(2),
    };
    return calc[action];
}
function main() {
    console.log(calc(1, '+', 3));
    console.log(calc(44, '-', 3));
    console.log(calc(33, '/', 3));
    console.log(calc(11, '*', 3));
}
main();
