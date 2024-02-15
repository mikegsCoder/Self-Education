// ---------- arrays ----------
let list: number[] = [10, 20, 30];
let colors: string[] = ['red', 'green', 'blue'];

console.log(list[0]);   // 10
console.log(colors[1]); // green

// ---------- arrays example ----------
let names: Array<string> = ['Tom', 'Bob', 'Alice'];
console.log(names[1]);  // Bob

// ---------- ReadonlyArray ----------
const people1: ReadonlyArray<string> = ['Tom', 'Bob', 'Sam'];

/*
people1[1] = 'Kate';   // Error!
people1.push('Kate');  // Error!
people1.pop();         // Error!
*/

// ---------- ReadonlyArray example ----------
function printUsers(users: readonly string[]) {
  for (const user of users) {
    console.log(user);
  }
}

function usersToString(users: ReadonlyArray<string>): String {
  return users.join(', ');
}

const people2: readonly string[] = ['Tom', 'Bob', 'Sam'];

printUsers(people2);
console.log(usersToString(people2));

// ---------- array decomposition ----------
const people3: string[] = ['Tom', 'Bob', 'Sam'];

const [first, second, third] = people3;
console.log(first);     // Tom
console.log(second);    // Bob
console.log(third);     // Sam

// ---------- array decomposition example ----------
const people4: string[] = ['Tom', 'Bob', 'Sam'];

const [one, ...rest] = people4;
console.log(one);       // Tom
console.log(rest[0]);   // Bob
console.log(rest[1]);   // Sam
