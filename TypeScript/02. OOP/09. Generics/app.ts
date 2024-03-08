// ---------- generics ----------
function getId<T>(id: T): T {
  return id;
}

let result1 = getId<number>(5);
console.log(result1);  // 5

let result2 = getId<string>('abc');
console.log(result2);  // abc

// ---------- generic array ----------
function getString<T>(args: Array<T>): string {
  return args.join(', ');
}

let result3 = getString<number>([1, 2, 34, 5]);
console.log(result3);  // 1, 2, 34, 5

// ---------- generic class ----------
class User1<T> {
  private _id: T;

  constructor(id: T) {
    this._id = id;
  }

  getId(): T {
    return this._id;
  }
}

let tom = new User1<number>(3);
console.log(tom.getId());    // 3
// tom = new User1<string>("asd");  // Error!

let alice = new User1<string>('xyz');
console.log(alice.getId());  // xyz

// ---------- generic interface ----------
interface IUser<T> {
  getId(): T;
}

class User2<T> implements IUser<T> {
  private _id: T;

  constructor(id: T) {
    this._id = id;
  }

  getId(): T {
    return this._id;
  }
}

// ---------- generic constraints ----------
function compareName1<T extends { name: string }>(obj1: T, obj2: T): void {
  if (obj1.name === obj2.name) {
    console.log('Names are equal.');
  }
  else {
    console.log('Names are not equal.');
  }
}

let bob: { name: string } = { name: 'Bob' };
let sam: { name: string } = { name: 'Sam' };

compareName1<{ name: string }>(bob, sam);  // Names are not equal.

// ---------- generic constraints example ----------
function compareName2<T extends { name: string }>(obj1: T, obj2: T): void {
  if (obj1.name === obj2.name) {
    console.log('Names are equal.');
  }
  else {
    console.log('Names are not equal.');
  }
}

class User3 {
  constructor(public name: string, public age: number) { }
}

let john = new User3('John', 38);
let george = new User3('George', 24);
compareName2<User3>(john, george);  // Names are not equal.

type Person = { id: number; name: string };
let jim: Person = { id: 1, name: 'Jim' };
let dave: Person = { id: 2, name: 'Dave' };
compareName2<Person>(jim, dave);  // Names are not equal.

// ---------- generic constraints example ----------
interface Named {
  name: string;
}

class NameInfo<T extends Named>{
  printName(obj: T): void {
    console.log(`Name: ${obj.name}`);
  }
}

class User4 {
  constructor(public name: string, public age: number) { }
}

let garry = new User4('Garry', 38);
let nameInfo1 = new NameInfo<User4>();
nameInfo1.printName(garry);  // Name: Garry

type Person2 = { id: number; name: string }
let peter: Person = { id: 1, name: 'Peter' };
let nameInfo2 = new NameInfo<Person2>();
nameInfo2.printName(peter);  // Name: Peter

// --------- new T ----------
function userFactory<T>(type: { new(): T; }): T {
  return new type();
}

class User5 {
  constructor() {
    console.log("User object created.");
  }
}

let user: User5 = userFactory(User5);  // User object created.
