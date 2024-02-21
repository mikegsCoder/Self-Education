// Write a function that prints numbers from m to n separated with ', '.

// ---------- solution 1 ----------
function numbers1(m: number, n: number) {
  let result: string = '';

  if (m < n) {
    result = m.toString();

    for (let i = m + 1; i <= n; i++) {
      result += ', ' + i.toString();
    }
  } else if (m > n) {
    result = m.toString();

    for (let i = m - 1; i >= n; i--) {
      result += ', ' + i.toString();
    }
  } else {
    result = m.toString();
  }

  console.log(result);
}

numbers1(3, 7); // 3, 4, 5, 6, 7
numbers1(7, 3); // 7, 6, 5, 4, 3
numbers1(5, 5); // 5
