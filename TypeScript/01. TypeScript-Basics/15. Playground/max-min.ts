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

// ---------- solution2: ----------
function maxMin2(arr: number[]): [number, number] {
  let min = arr[0];
  let max = arr[0];

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] < min) {
      min = arr[i];
    }
    if (arr[i] > max) {
      max = arr[i];
    }
  }

  return [min, max];
}

const result2 = maxMin2([-2, 0, 7, 3, 5]);
console.log(`The min value is ${result2[0]}.`);
console.log(`The max value is ${result2[1]}.`);