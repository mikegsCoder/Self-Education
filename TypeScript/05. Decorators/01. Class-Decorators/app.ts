// ---------- class decorator ----------
function sealed(constructor: Function) {
  console.log('sealed decorator');
  Object.seal(constructor);
  Object.seal(constructor.prototype);
}

@sealed
class User1 {
  name: string;

  constructor(name: string) {
    this.name = name;
  }

  print(): void {
    console.log(this.name);
  }
}

// ---------- class decorator example ----------
function logger<TFunction extends Function>(target: TFunction): TFunction {
  let newConstructor: Function = function (name: string) {
    console.log('Creating new instance');
    this.name = name;
    this.age = 23;
    this.print = function (): void {
      console.log(this.name, this.age);
    }
  }

  return <TFunction>newConstructor;
}

@logger
class User2 {
  name: string;

  constructor(name: string) {
    this.name = name;
  }

  print(): void {
    console.log(this.name);
  }
}

let tom = new User2('Tom');
let bob = new User2('Bob');
tom.print();
bob.print();
// Creating new instance
// Creating new instance
// Tom 23
// Bob 23
