// Write a function that sorts a numeric array in ascending or descending order.

// ---------- solution ----------
function arrSort(arr: number[], argument: string): number[] {
  if (argument.toLocaleLowerCase() === 'ascending') {
    return arr.sort((n1, n2) => n1 - n2);
  } else if (argument.toLocaleLowerCase() === 'descending') {
    return arr.sort((n1, n2) => n2 - n1);
  } else {
    return arr;
  }
}

console.log(arrSort([3, -1, 0, 15, 7], 'ascending'))  // [ -1, 0, 3, 7, 15 ]
console.log(arrSort([3, -1, 0, 15, 7], 'descending')) // [ 15, 7, 3, 0, -1 ]
console.log(arrSort([3, -1, 0, 15, 7], 'something'))  // [ 3, -1, 0, 15, 7 ]
