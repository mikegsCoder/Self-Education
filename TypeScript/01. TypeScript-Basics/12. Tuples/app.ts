// ---------- tuples ----------
let user: [string, number] = ['Tom', 36];

console.log(user[1]);  // 36
user[1] = 37;
console.log(user[1]);  // 37

// ---------- tuples example ----------
for (const prop of user) {
  console.log(prop);
}

// ---------- tuples as function parameters ----------
function printUser(user: [string, number]) {
  console.log(user[0]);
  console.log(user[1]);
}

let tom: [string, number] = ['Tom', 36];
printUser(tom);
// Tom
// 36

// ---------- tuples as return type ----------
function createUser(name: string, age: number): [string, number] {
  return [name, age];
}

let user1 = createUser('Bob', 41);
console.log(user1[0]);  // Bob
console.log(user1[1]);  // 41
