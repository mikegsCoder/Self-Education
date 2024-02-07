// ---------- functions ----------
function addExample1(a, b) {
  return a + b;
}

let result1 = addExample1(1, 2);      // 3
let result2 = addExample1("1", "2");  // 12

// ---------- function parameters ----------
function addExample2(a: number, b: number) {
  let result = a + b;
  console.log(result);
}

addExample2(20, 30);  // 50
addExample2(10, 15);  // 25

// ---------- using external variables in function ----------
let x: number = 1.5;

function multiplication(a: number) {
  let result = a * x;
  console.log(result);
}

multiplication(20);  // 30
multiplication(10);  // 15

// ---------- function return type ----------
function addExample3(a: number, b: number): number {
  return a + b;
}

let result = addExample3(1, 2);
console.log(result);  // 3
