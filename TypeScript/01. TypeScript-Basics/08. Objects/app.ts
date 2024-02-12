// ---------- objects ----------
let person1 = { name: 'Tom', age: 34 };

console.log(person1.name);
console.log(person1['name']);

// ---------- objects example ----------
let person2: { name: string; age: number } = { name: 'John', age: 35 };

console.log(person2.name);   // John

// ---------- optional properties ----------
let person3: { name: string; age?: number };

person3 = { name: 'Tom', age: 23 };
console.log(person3.name);   // Tom

person3 = { name: 'Bob' };
console.log(person3.name);   // Bob
console.log(person3.age);    // undefined

// ---------- objects in functions ----------
function printUser(user: { name: string; age: number }) {
  console.log(`name: ${user.name}  age: ${user.age}`);
}

let tom = { age: 36, name: 'Tom' };
printUser(tom);

let bob = { name: 'Bob', age: 44, isMarried: true };
printUser(bob);

// ---------- objects as return type ----------
function defaultUser(): { name: string; age: number } {
  return { name: 'Tom', age: 37 };
}

let user = defaultUser();
console.log(`name: ${user.name}  age: ${user.age}`);

// ---------- operator in ----------
let user1: { name: string; age?: number } = { name: 'Tom', age: 23 };
let user2: { name: string; age?: number } = { name: 'Bob' };

function printUser1(user: { name: string; age?: number }) {
  if ('age' in user) {
    console.log(`Name: ${user.name} Age: ${user.age}`);
  }
  else {
    console.log(`Name: ${user.name}`);
  }
}

printUser1(user1);
printUser1(user2);

// ---------- object decomposition ----------
function printUser2({ name, age }: { name: string; age: number }) {
  console.log(`name: ${name}  age: ${age}`);
}

let user3 = { name: 'Tom', age: 36 };
printUser2(user3);
