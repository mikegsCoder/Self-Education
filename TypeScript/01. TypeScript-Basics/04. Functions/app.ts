// ---------- functions ----------
function addExample1(a, b) {
  return a + b;
}

let result1 = addExample1(1, 2);      // 3
let result2 = addExample1("1", "2");  // 12

// ---------- function parameters ----------
function addExample2(a: number, b: number) {
  let result = a + b;
  console.log(result);
}

addExample2(20, 30);  // 50
addExample2(10, 15);  //25
