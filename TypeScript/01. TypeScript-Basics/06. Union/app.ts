// ---------- union ----------
let id1: number | string;

id1 = "1345dgg5";
console.log(id1);  // 1345dgg5

id1 = 234;
console.log(id1);  // 234

// ---------- union as function parameter example ----------
function printId(id2: number | string) {
  console.log(`Id: ${id2}`);
}

let id2: string | number = 'xyz123';

printId('1h2e3l4o5');
printId(9876);
printId(id2);
