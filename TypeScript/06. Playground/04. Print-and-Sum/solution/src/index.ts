// tsc && node ./public/index.js
function printAndSum(start: number, end: number): void {
  let sum: number = 0;
  let numbers: number[] = [];

  for (let number = start; number <= end; number++) {
    sum += number;
    numbers.push(number);
  }

  console.log(numbers.join(' '));
  console.log(`Sum: ${sum}`);
}

printAndSum(5, 10);
printAndSum(0, 26);
printAndSum(50, 60);
