// ---------- generics ----------
function getId<T>(id: T): T {
  return id;
}

let result1 = getId<number>(5);
console.log(result1);  // 5

let result2 = getId<string>('abc');
console.log(result2);  // abc

// ---------- generic array ----------
function getString<T>(args: Array<T>): string {
  return args.join(', ');
}

let result3 = getString<number>([1, 2, 34, 5]);
console.log(result3);  // 1, 2, 34, 5
