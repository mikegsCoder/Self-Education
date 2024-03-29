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

// ---------- optional elements ----------
let bob: [string, number, boolean?] = ['Bob', 41, true];
let john: [string, number, boolean?] = ['John', 36];

// ---------- tuple with optional elements as function parameter ----------
function printUser1(user: [string, number, boolean?]) {
  if (user[2] !== undefined) {
    console.log(`name: ${user[0]}  age: ${user[1]}  isMarried: ${user[2]}`);
  }
  else {
    console.log(`name: ${user[0]}  age: ${user[1]}`);
  }
}

printUser1(bob);
printUser1(john);

// ---------- tuple example ----------
function printMarks(marks: [string, ...number[]]) {
  for (const mark of marks) {
    console.log(mark);
  }
}

let math: [string, ...number[]] = ['Math', 5, 4, 5, 4, 4];
let physics: [string, ...number[]] = ['Physics', 5, 5, 5];

printMarks(math);
printMarks(physics);

// ---------- tuple example ----------
let mathTuple: [string, ...number[]] = ['Math', 5, 4, 5, 4, 4];
let physicsTuple: [...number[], string] = [5, 5, 5, 'Physics'];
let chemistryTuple: [string, ...number[], boolean] = ['Chemistry', 3, 3, 4, 5, false];

// ---------- readonly tuple ----------
const tomReadonly: readonly [string, number] = ['Tom', 36];

// tomReadonly[1] = 37; // Error!

// ---------- tuple destructuring ----------
let james: [string, number, boolean] = ['James', 36, false];
let [username, userage, isMarried] = james;   // decomposition

console.log(username);      // James
console.log(userage);       // 36
console.log(isMarried);     // false

// ---------- tuple destructuring example ----------
const [nameOfUser, ...rest] = james;

console.log(nameOfUser);    // James
console.log(rest[0]);       // 36
console.log(rest[1]);       // false

// ---------- tuple destructuring example ----------
let peter: [string, number, boolean, number] = ['Peter', 36, false, 170];
const [, age, , height] = peter;

console.log(age);           // 36
console.log(height);        // 170
