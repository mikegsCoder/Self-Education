// write a simple function to calculate factorial.

// ---------- solution ----------
function factorial(num: number): number {
  if (num == 0) {
    return 1;
  }
  else {
    return num * factorial(num - 1);
  }
}

console.log(factorial(10)) // 3628800
console.log(factorial(20)) // 2432902008176640000
