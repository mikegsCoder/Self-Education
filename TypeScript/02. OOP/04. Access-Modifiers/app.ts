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
