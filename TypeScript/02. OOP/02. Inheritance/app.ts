// ---------- inheritance ----------
class Person1 {
  name: string;

  constructor(userName: string) {
    this.name = userName;
  }

  print(): void {
    console.log(`Name: ${this.name}`);
  }
}

class Employee1 extends Person1 {
  company: string;

  work(): void {
    console.log(`${this.name} works in company ${this.company}.`);
  }
}

let bob: Employee1 = new Employee1('Bob');
bob.print();  // Name: Bob

bob.company = 'Microsoft';
bob.work();  // Bob works in company Microsoft.
