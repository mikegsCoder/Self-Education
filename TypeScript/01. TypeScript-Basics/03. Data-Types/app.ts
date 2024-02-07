// ---------- data types in TS ----------
// - boolean = true / false
// - number
// - string
// - Array
// - Tuple
// - Enum
// - Any
// - Symbol
// - null and undefined
// - Never

// ---------- boolean ----------
let isEnabled: boolean = true;
let isAlive: boolean = false;

console.log(isEnabled);  // true
console.log(isAlive);    // false

// ---------- number ----------
let age: number = 35;
let height: number = 1.754;

console.log(age);     // 35
console.log(height);  // 1.754

// decimal
let decimal: number = 6;
// hex
let hex: number = 0xf00d;     // 61453 in decimal
// binary
let binary: number = 0b1010;  // 10 in decimal
// octal
let octal: number = 0o744;    // 484 in decimal

console.log(decimal);
console.log(hex);
console.log(binary);
console.log(octal);

// ---------- string ----------
let firstName: string = 'Tom';
let lastName: string = 'Johns';
let fullName: string = firstName + ' ' + lastName;

console.log(fullName);  // Tom Jones

// ---------- any ----------
let someVar: any = 'hello';
console.log(someVar);           // hello
console.log(typeof (someVar));  // string

someVar = 25;
console.log(someVar);           // 25
console.log(typeof (someVar));  // number
