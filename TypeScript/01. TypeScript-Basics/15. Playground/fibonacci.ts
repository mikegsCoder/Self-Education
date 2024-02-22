// write simple function that calculates Fibonacci sequence.

// ---------- solution ----------
function calcValue(input: number): number {
  if (input < 1) {
    return 0;
  }
  if (input < 2) {
    return 1;
  }

  return calcValue(input - 2) + calcValue(input - 1);
};

function fibonacci(num: number) {
  const sequence: number[] = [];

  for (let n = 0; n < num; ++n) {
    const val = calcValue(n);
    sequence.push(val);
  }

  console.log('Fibonacci sequence: ' + sequence.join(', '));
}

fibonacci(5);  // Fibonacci sequence: 0, 1, 1, 2, 3
fibonacci(15); // Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377