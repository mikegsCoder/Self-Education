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
