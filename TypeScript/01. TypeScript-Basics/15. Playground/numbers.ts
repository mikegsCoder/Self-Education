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

// ---------- solution 2 ----------
function numbers2(m: number, n: number) {
  let arr: number[] = [];

  if (m < n) {
    for (let i = m; i <= n; i++) {
      arr.push(i);
    }
  } else if (m > n) {
    for (let i = m; i >= n; i--) {
      arr.push(i);
    }
  } else {
    arr = [m];
  }

  console.log(arr.join(', '));
}

numbers2(3, 7); // 3, 4, 5, 6, 7
numbers2(7, 3); // 7, 6, 5, 4, 3
numbers2(5, 5); // 5
