// ---------- interfaces ----------
interface IUser {
  id: number;
  name: string;
}

let employee1: IUser = {
  id: 1,
  name: 'Tom'
}

console.log('id: ', employee1.id);
console.log('name: ', employee1.name);

// ---------- interfaces as method and function parameters ----------
let employee2: IUser = {
  id: 2,
  name: 'Alice'
}

function printUser(user: IUser): void {
  console.log('id: ', user.id);
  console.log('name: ', user.name);
}

printUser(employee2);  
// id:  2
// name:  Alice

// ---------- interfaces as return type ----------
function buildUser(userId: number, userName: string): IUser {
  return { id: userId, name: userName };
}

let newUser = buildUser(3, 'Bill');

console.log('id: ', newUser.id);      // id:  3
console.log('name: ', newUser.name);  // name:  Bill

// ---------- optional properties ----------
interface IUserNew {
  id: number;
  name: string;
  age?: number;
}

let employee: IUserNew = {
  id: 1,
  name: 'Alice',
  age: 23
}

let manager: IUserNew = {
  id: 2,
  name: 'Tom'
}

// ---------- readonly properties ----------
interface Point {
  readonly x: number;
  readonly y: number;
}

let p: Point = { x: 10, y: 20 };
console.log(p);  // { x: 10, y: 20 }
// p.x = 5;      // Error!

// ---------- interface example ----------
interface IUser1 {
  id: number;
  name: string;
  sayWords(words: string): void;
}

let employee3: IUser1 = {
  id: 1,
  name: 'Alice',
  sayWords: function (words: string): void {
    console.log(`${this.name} says "${words}"`);
  }
}

employee3.sayWords('Hi, how are you?'); // Alice says "Hi, how are you?"

// ---------- class interfaces ----------
interface IUser2 {
  id: number;
  name: string;
  getFullName(surname: string): string;
}

class User implements IUser2 {
  id: number;
  name: string;
  age: number;

  constructor(userId: number, userName: string, userAge: number) {
    this.id = userId;
    this.name = userName;
    this.age = userAge;
  }

  getFullName(surname: string): string {
    return this.name + ' ' + surname;
  }
}

let tom = new User(1, 'Tom', 35);
console.log(tom.getFullName('Simpson')); // Tom Simpson

// ---------- interface extension ----------
interface IUser3 {
  id: number;
  name: string;
}

interface IUser3 {
  age: number;
}

let employee4: IUser3 = {
  id: 1,
  name: 'Alice',
  age: 31
}

function printUser4(user: IUser3): void {
  console.log(`id: ${user.id}  name: ${user.name}  age: ${user.age}`);
}

printUser4(employee4);  // id: 1  name: Alice  age: 31

// ---------- interface inheritance ----------
interface IMovable {
  speed: number;
  move(): void;
}

interface ICar extends IMovable {
  fill(): void;
}

class Car implements ICar {
  speed: number;

  move(): void {
    console.log("Car moves at speed " + this.speed + " km/h.");
  }

  fill(): void {
    console.log("Fill car with fuel.");
  }
}

let auto = new Car();
auto.speed = 60;

auto.fill();  // Fill car with fuel.
auto.move();  // Car moves at speed 60 km/h.

// ---------- function interface ----------
interface FullNameBuilder {
  (name: string, surname: string): string;
}

let simpleBuilder: FullNameBuilder = function (name: string, surname: string): string {
  return 'Mr. ' + name + ' ' + surname;
}

let fullName = simpleBuilder('Bob', 'Simpson');
console.log(fullName);  // Mr. Bob Simpson

// ---------- array interface ----------
interface StringArray {
  [index: number]: string;
}

let phones: StringArray;
phones = ['iPhone 7', 'HTC 10', 'HP Elite x3'];

let myPhone: string = phones[0];
console.log(myPhone);  // iPhone 7

// ---------- array interface example ----------
interface Dictionary {
  [index: string]: string;
}

var colors: Dictionary = {};
colors['red'] = '#ff0000';
colors['green'] = '#00ff00';
colors['blue'] = '#0000ff';

console.log(colors['red']);  // #ff0000

// ---------- interface example ----------
interface PersonInfo {
  (name: string, surname: string): void;
  fullName: string;
  password: string;
  authenticate(): void;
}

function personBuilder(): PersonInfo {
  let person = <PersonInfo>function (name: string, surname: string): void {
    person.fullName = name + ' ' + surname;
  };

  person.authenticate = function () {
    console.log(person.fullName + ' has personal password ' + person.password);
  };

  return person;
}

let person = personBuilder();
person('Tom', 'Simpson');
person.password = 'qwerty';

person.authenticate();  // Tom Simpson has personal password qwerty
