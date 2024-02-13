// ---------- aliases ----------
type id = number | string;

let userId: id = 2;
console.log(`Id: ${userId}`); // Id: 2

userId = 'qwerty';
console.log(`Id: ${userId}`); // Id: qwerty

// ---------- alias example ----------
// function parameter is alias
function printId(inputId: id) {
  console.log(`Id: ${inputId}`);
}
// return type is alias
function getId(isNumber: boolean): id {
  if (isNumber)
    return 1;
  else
    return '1';
}

printId(12345);
printId('qwerty');
console.log(getId(true));

// ---------- alias example ----------
type Person = { name: string; age: number };

let tom: Person = { name: 'Tom', age: 36 };
let bob: Person = { name: 'Bob', age: 41 };

function printPerson(user: Person) {
  console.log(`Name: ${user.name}  Age: ${user.age}`);
}

printPerson(tom); // Name: Tom  Age: 36
printPerson(bob); // Name: Bob  Age: 41

// ---------- alias extension ----------
// Employee extends Person
type Employee = Person & { company: string };

let person: Person = { name: 'Tom', age: 32 };
let employe: Employee = { name: 'Bob', age: 43, company: 'Microsoft' };

function printPerson1(user: Person) {
  console.log(`Name: ${user.name}  Age: ${user.age}`);
}

printPerson1(person);
printPerson1(employe);  // employee is also Person
