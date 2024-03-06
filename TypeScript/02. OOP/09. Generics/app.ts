// ---------- generics ----------
function getId<T>(id: T): T {
  return id;
}

let result1 = getId<number>(5);
console.log(result1);  // 5

let result2 = getId<string>('abc');
console.log(result2);  // abc
