// tsc && node .\public\index.js

// ---------- Solution 1 ----------
// function calc(firstNum: number, action: string, secondNum: number): string {
//   switch (action) {
//     case '+':
//       return (firstNum + secondNum).toFixed(2);
//     case '-':
//       return (firstNum - secondNum).toFixed(2);
//     case '*':
//       return (firstNum * secondNum).toFixed(2);
//     case '/':
//       return (firstNum / secondNum).toFixed(2);
//   }
// }

// ---------- Solution 2 ----------
type CalcDictionary = {
  [key: string]: string;
};

function calc(firstNum: number, action: string, secondNum: number): string {
  const calc: CalcDictionary = {
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
