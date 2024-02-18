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

// ---------- function parameters example ----------
function sum1(a: number, b: number, c?: number): number {
  let result = a + b;

  if (c !== undefined) {
    result += c;
  }

  return result;
}

const numbers1 = [1, 3] as const;
let num3 = sum1(...numbers1);   // a = 1  b = 3
console.log(num1);              // 4

const numbers2 = [1, 3, 7] as const;
let num4 = sum1(...numbers2);   // a = 1  b = 3  c = 7
console.log(num2);              // 11

// ---------- function parameters example ----------
function printValues(name: string, age: number) {
  console.log(name);
  console.log(age);
}

const values = ['Tom', 36] as const;
printValues(...values);     // name = Tom, age = 36
