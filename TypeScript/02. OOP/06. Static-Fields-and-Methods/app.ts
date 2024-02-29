// ---------- static fields and methods ----------
class Person1 {
  age: number;
  name: string;

  static retirementAge: number = 70;

  static calculateYears(age: number): number {
    return Person1.retirementAge - age;
    // return Person1.retirementAge - this.age; // Error! 
  }

  constructor(name: string, age: number) {
    this.name = name;
    this.age = age;
  }
}

let tom = new Person1('Tom', 36);
let years = Person1.calculateYears(36);

console.log(Person1.retirementAge); // 70
console.log(years);                 // 34

// ---------- access modifiers ----------
class Person2 {
  age: number;
  name: string;

  private static retirementAge: number = 70;

  static calculateYears(age: number): number {
    return Person2.retirementAge - age;
  }

  constructor(name: string, age: number) {
    this.name = name;
    this.age = age;
  }
}

