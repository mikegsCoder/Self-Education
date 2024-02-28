// ---------- get and set ----------
class Person1 {

  name: string;
  private _age: number;
  private _name: string;

  public get age(): number {
    return this._age;
  }

  public set age(n: number) {
    if (n < 0 || n > 110) {
      console.log("Invalid age!");
    }
    else {
      this._age = n;
    }
  }
}

let tom = new Person1();
tom.name = 'Tom';
tom.age = 36;

console.log(tom.age);   // 36
tom.age = -1243;        // Invalid age!   
console.log(tom.age);   // 36 
