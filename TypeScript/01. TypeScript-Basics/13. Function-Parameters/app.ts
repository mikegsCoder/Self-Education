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

// ---------- function parameters example ----------
function sum(...args: number[]): number {
  let result = 0;

  for (let i = 0; i < args.length; i++) {
    result += args[i];
  }

  return result;
}

const numbers = [1, 3, 5, 7, 9] as const;
let num = sum(...numbers);
console.log(num);  // 25
