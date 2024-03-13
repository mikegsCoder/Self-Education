// ---------- namespaces ----------
namespace Personnel1 {
  export class Employee1 {
    constructor(public name: string) {
    }
  }
}

let alice = new Personnel1.Employee1('Alice');
console.log(alice.name);    // Alice

// ---------- namespaces example ---------
namespace Personnel2 {
  export interface IUser {
    displayInfo(): void;
  }

  export class Employee2 {
    constructor(public name: string) {
    }
  }

  export function work(emp: Employee2): void {
    console.log(emp.name, 'is working');
  }

  export let defaultUser = { name: 'Kate' };

  export let value = 'Hello';
}

let tom = new Personnel2.Employee2('Tom');
Personnel2.work(tom);  // Tom is working

console.log(Personnel2.defaultUser.name);  // Kate
console.log(Personnel2.value);             // Hello

// ---------- namespace in separate file ---------
/// <reference path='personnel.ts' />

let bob = new Personnel.Employee('Bob')
console.log(bob.name);  // Bob

let sam = new Personnel.Manager('Sam');
console.log(sam.name);  // Sam

// tsc --outFile app.js personnel.ts app.ts
