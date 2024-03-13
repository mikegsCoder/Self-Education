// ---------- namespaces ----------
namespace Personnel1 {
  export class Employee1 {
    constructor(public name: string) {
    }
  }
}

let alice = new Personnel1.Employee1('Alice');
console.log(alice.name);    // Alice
