// ---------- void ----------
function hello() {
  console.log("Hello TypeScript!");
};

const message: () => void = hello;
message();

// ---------- number ----------
function sumFunction(x: number, y: number): number {
  return x + y;
};

function subtractFunction(a: number, b: number): number {
  return a - b;
};

let op: (x: number, y: number) => number;

op = sumFunction;
console.log(op(2, 4));  // 6

op = subtractFunction;
console.log(op(6, 4));  // 2

// ---------- functions as parameters to another functions ----------
function sum(x: number, y: number): number {
  return x + y;
};

function multiply(a: number, b: number): number {
  return a * b;
};

function mathOp(x: number, y: number, op: (a: number, b: number) => number): number {
  return op(x, y);
}

console.log(mathOp(10, 20, sum));       // 30 
console.log(mathOp(10, 20, multiply));  // 200 
