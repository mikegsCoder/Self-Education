// Write a function that takes an array of numbers and returns the max and min elements.

// ---------- solution1: ----------
function maxMin1(arr: number[]): [number, number] {
  const min = Math.min(...arr);
  const max = Math.max(...arr);

  return [min, max];
}

const result1 = maxMin1([-2, 0, 7, 3, 5]);
console.log(`The min value is ${result1[0]}.`);
console.log(`The max value is ${result1[1]}.`);
