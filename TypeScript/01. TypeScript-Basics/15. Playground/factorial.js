// write a simple function to calculate factorial.
// ---------- solution ----------
function factorial(num) {
    if (num == 0) {
        return 1;
    }
    else {
        return num * factorial(num - 1);
    }
}
console.log(factorial(10)); // 
console.log(factorial(20)); // 
