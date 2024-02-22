/*
Write a program, that reads an array of numbers and commands, to manipulate the array as follows:
- Delete {element} – delete all elements in the array, which are equal to the given element.
- Insert {element} {position} – insert an element at the given position.
- end - stop the program. 
Print the numbers in the result array separated by ', '.
*/

// ---------- solution ----------
function arrMod(input: string): string {
  const [arr, ...ops] = input.split('\n');
  let nums: number[] = arr.split(' ').map(x => Number(x));

  ops.forEach(currentOp => {
    const [operation, value, index = nums.length] = currentOp.split(' ');

    if (operation.toLowerCase() === 'delete') {
      nums = nums.filter(x => x !== Number(value));
    } else if (operation.toLowerCase() === 'insert') {
      nums = [...nums.slice(0, Number(index)), Number(value), ...nums.slice(Number(index))];
    }
  });

  return nums.map(x => x.toString()).join(', ');
}

const result1 = arrMod('5 3 8 10 34 7 546 32\nDelete 5\nInsert 10 1\nDelete 7\nend');
const result2 = arrMod('45 1 27 -5 6 74\nInsert 50 2\nInsert 11 5\nDelete 4\nend');

console.table(result1); // 3, 10, 8, 10, 34, 546, 32
console.table(result2); // 45, 1, 50, 27, -5, 11, 6, 74
