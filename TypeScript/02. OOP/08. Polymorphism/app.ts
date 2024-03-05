// ---------- polymorphism ----------
class Person1 {
  name: string;

  constructor(userName: string) {
    this.name = userName;
  }
}

class Employee1 extends Person1 {
  company: string;

  constructor(userName: string, company: string) {
    super(userName);
    this.company = company;
  }
}

function printPerson(user: Person1): void {
  console.log(`Person ${user.name}`);
}

function personFactory(userName: string): Person1 {
  return new Employee1(userName, 'default');
}

let user1: Person1 = new Employee1('Tom', 'Microsoft');
printPerson(user1);  // Person Tom

let user2 = personFactory('Bob');
printPerson(user2);  // Person Bob

// ---------- polymorphism example ----------
class Person2 {
  name: string;

  constructor(userName: string) {
    this.name = userName;
  }
}

class Employee2 extends Person2 {
  company: string;

  constructor(userName: string, company: string) {
    super(userName);
    this.company = company;
  }
}

let user3: Person2 = new Employee2('Tom', 'Microsoft');
// console.log(user3.company);   // Error!

let user3Employee1: Employee2 = <Employee2>user3; // type conversion
console.log(user3Employee1.company);  // Microsoft

let user3Employee2: Employee2 = user3 as Employee2; // type conversion
console.log(user3Employee2.company);  // Microsoft
