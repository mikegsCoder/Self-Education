// ---------- public ----------
class Person1 {
  public name: string;
  public year: number;
}

// ---------- private ----------
class Person2 {
  private _name: string;
  private _year: number;

  constructor(name: string, age: number) {
    this._name = name;
    this._year = this.setYear(age);
  }

  public print(): void {
    console.log(`Name: ${this._name}  Year of birth: ${this._year}`);
  }

  private setYear(age: number): number {
    return new Date().getFullYear() - age;
  }
}

let tom = new Person2('Tom', 24);
tom.print(); // Name: Tom  Year of birth: 2000

// console.log(tom._name);  // Error!
// tom.setYear(45);         // Error!

// ---------- protected ----------
class Person3 {
  protected name: string;
  private year: number;

  constructor(name: string, age: number) {
    this.name = name;
    this.year = this.setYear(age);
  }

  protected printPerson(): void {
    console.log(`Name: ${this.name}  Year of birth: ${this.year}`);
  }

  private setYear(age: number): number {
    return new Date().getFullYear() - age;
  }
}

class Employee extends Person3 {
  protected company: string;

  constructor(name: string, age: number, company: string) {
    super(name, age);
    this.company = company;
  }

  public printEmployee(): void {
    // console.log("Year: " + this.year);   // field year is inaccessible, because it is private
    // setYear(25);                         // method setYear is inaccessible, because it is private
    this.printPerson();                     // method printPerson is accessible, because it is protected
    console.log(`Company: ${this.company}`);
  }
}

let sam = new Employee('Sam', 31, 'Microsoft');
sam.printEmployee();
/*
Name: Sam  Year of birth: 1993
Company: Microsoft
*/

// ---------- set access modifiers in constructor ----------
class Person4 {
  constructor(private name: string, private age: number) { }

  printPerson(): void {
    console.log(`Name: ${this.name}  Age: ${this.age}`);
  }
}
