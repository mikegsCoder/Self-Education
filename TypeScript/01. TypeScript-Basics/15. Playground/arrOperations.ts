/*
    You will be given an array of integers on the first line of input. 
    You will be receiving operations you have to apply on the array until you receive the "End" command. 
    The possible commands are:
     - Add {number} – add number at the end.
     - Insert {number} {index} – insert number at given index.
     - Remove {index} – remove at index.
     - Shift left {count} – first number becomes last ‘count’ times.
     - Shift right {count} – last number becomes first ‘count’ times.
    If index is outside of the bounds of the array print "Invalid index".
*/

// ---------- solution ----------
function operations(args: number[]) {
  let arr: number[] = [];

  if (Array.isArray(args)) {
    arr.push(...args);
  }

  function modify(command: string, x?: number, y?: number) {
    const num: number | null = x ?? null;
    const index: number | null = y ?? null;

    function verifyIndex(i: number | null): number | null {
      if (i !== null && 0 <= i && i <= arr.length - 1) {
        return i;
      } else if (i !== null && (0 > i || i > arr.length - 1)) {
        console.log('Invalid index');
      }
      return null;
    }

    switch (command) {
      case 'Add':
        if (num) {
          arr.push(num);
        }
        break;
      case 'Insert':
        if (num) {
          const i = verifyIndex(index);
          if (i !== null) {
            arr = [...arr.slice(0, i), num, ...arr.slice(i)];
          }
        }
        break;
      case 'Remove':
        if (num !== null && num >= 0) {
          const i = verifyIndex(num);
          if (i !== null) {
            arr = [...arr.slice(0, i), ...arr.slice(i + 1)];
          }
        }
        break;
      case 'Shift left':
        if (num) {
          arr = [...arr.slice(num, arr.length), ...arr.slice(0, num)];
        }
        break;
      case 'Shift right':
        if (num) {
          arr = [...arr.slice(arr.length - num, arr.length), ...arr.slice(0, arr.length - num)];
        }
        break;
      case 'End':
        console.table(arr);
        break;
      default:
        break;
    }
  }

  return modify;
}

const test = operations([1, 2, 3,]);
test('Add', 4);
test('Add', 5);
test('Add', 6);
test('Add', 7);
test('End');
test('Insert', 666, -1);
test('Insert', 200, 1);
test('Insert', 300, 5);
test('Insert', 400, 8);
test('Insert', 100, 0);
test('End');
test('Remove', 999);
test('Remove', 9);
test('Remove', 6);
test('Remove', 2);
test('Remove', 0);
test('End');
test('Shift left', 2);
test('End');
test('Shift right', 3);
test('End');
