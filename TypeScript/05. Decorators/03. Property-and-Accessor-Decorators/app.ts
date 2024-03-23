// ---------- property decorator ----------
function format() {
  return function (target: Object, propertyKey: string) {
    let value: string;
    const getter = function () {
      return "Mr./Ms." + value;
    };
    const setter = function (newVal: string) {
      if (newVal.length > 2) {
        value = newVal
      }
    };

    Object.defineProperty(target, propertyKey, {
      get: getter,
      set: setter
    });
  }
}

class User1 {
  @format()
  name: string;

  constructor(name: string) {
    this.name = name;
  }

  print(): void {
    console.log(this.name);
  }
}

let tom = new User1('Tom');
tom.print();  // Mr./Ms.Tom
tom.name = 'Tommy';
tom.print();  // Mr./Ms.Tommy
tom.name = 'To';
tom.print();  // Mr./Ms.Tommy

// ---------- accessor decorator ----------
function validator(target: any, propertyKey: string, descriptor: PropertyDescriptor) {
  const oldSet = descriptor.set;

  descriptor.set = function (value: string) {
    if (value === 'admin') {
      throw new Error('Invalid value!');
    }

    if (oldSet !== undefined) {
      oldSet.call(this, value);
    }
  }
}

class User2 {
  private _name: string;

  constructor(name: string) {
    this.name = name;
  }

  public get name(): string {
    return this._name;
  }

  @validator
  public set name(n: string) {
    this._name = n;
  }
}

let bob = new User2('Bob');
console.log(bob.name);  // Bob

bob.name = 'admin';
console.log(bob.name);  // Error: Invalid value!
