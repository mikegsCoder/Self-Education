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
