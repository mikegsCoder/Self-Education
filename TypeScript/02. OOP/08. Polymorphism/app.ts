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
