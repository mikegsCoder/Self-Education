// Write a simple function to sum numbers from m to n.

// ---------- solution: ----------
function sum(m: number, n: number) {
  const resultMessage: string = 'The sum is ';

  if (m == n) {
    console.log(resultMessage + m)
  } else {
    const min = Math.min(m, n);
    const max = Math.max(m, n);
    let sum: number = 0;

    for (let i = min; i <= max; i++) {
      sum += i
    }

    console.log(resultMessage + sum);
  }
}

sum(2, 4);   // The sum is 9
sum(-2, 2);  // The sum is 0
sum(3, 3);   // The sum is 3