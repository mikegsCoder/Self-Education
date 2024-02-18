// ---------- function parameters ----------
function addNumbers(firstNumber: number, ...numberArray: number[]): number {
  let result = firstNumber;

  for (let i = 0; i < numberArray.length; i++) {
    result += numberArray[i];
  }

  return result;
}

let num1 = addNumbers(3, 7, 8);
console.log(num1);  // 18

let num2 = addNumbers(3, 7, 8, 9, 4);
console.log(num2);  // 31
