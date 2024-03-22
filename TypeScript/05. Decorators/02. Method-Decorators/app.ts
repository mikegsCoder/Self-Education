// ---------- method decorators ----------
function deprecated(
  target: any,
  propertyName: string,
  descriptor: PropertyDescriptor) {
  console.log('Method is deprecated');
}

interface PropertyDescriptor {
  configurable?: boolean;
  enumerable?: boolean;
  value?: any;
  writable?: boolean;
  get?(): any;
  set?(v: any): void;
}

// ---------- method decorator example ----------
function readable(onlyRead: boolean) {
  return function (target: Object, propertyKey: string, descriptor: PropertyDescriptor) {
    descriptor.writable = !onlyRead;
  };
}

class User1 {
  name: string;
  constructor(name: string) {
    this.name = name;
  }

  @readable(true)
  print(): void {
    console.log(this.name);
  }
}

let tom = new User1('Tom');
tom.print = function () {
  console.log('print has been changed');
}
tom.print();  // Tom

// ---------- method parameters and return type ----------
function log(
  target: Object,
  method: string,
  descriptor: PropertyDescriptor) {
  let originalMethod = descriptor.value;

  descriptor.value = function (...args: number[]) {
    console.log(JSON.stringify(args));

    let returnValue = originalMethod.apply(this, args);
    console.log(`${JSON.stringify(args)} => ${returnValue}`)

    return returnValue;
  }
}

class Calculator {
  @log
  add(x: number, y: number): number {
    return x + y;
  }
}

let calc = new Calculator();
let z = calc.add(4, 5);
z = calc.add(6, 7);

// ---------- method parameters decorators ----------
function logParameter(target: any, key: string, index: number) {
  var metadataKey = `__log_${key}_parameters`;

  if (Array.isArray(target[metadataKey])) {
    target[metadataKey].push(index);
  }
  else {
    target[metadataKey] = [index];
  }
}

function logMethod(target: any, key: string, descriptor: PropertyDescriptor) {
  var originalMethod = descriptor.value;

  descriptor.value = function (...args: any[]) {
    var metadataKey = `__log_${key}_parameters`;
    var indices = target[metadataKey];

    if (Array.isArray(indices)) {
      for (var i = 0; i < args.length; i++) {
        if (indices.indexOf(i) !== -1) {
          var arg = args[i];
          var argStr = JSON.stringify(arg) || arg.toString();
          console.log(`${key} arg[${i}]: ${argStr}`);
        }
      }

      var result = originalMethod.apply(this, args);
      return result;
    }
    else {
      var a = args.map(a => (JSON.stringify(a) || a.toString())).join();
      var result = originalMethod.apply(this, args);
      var r = JSON.stringify(result);
      console.log(`Call: ${key}(${a}) => ${r}`);

      return result;
    }
  }

  return descriptor;
}

class User2 {
  private name: string;

  constructor(name: string) {
    this.name = name;
  }

  @logMethod
  setName(@logParameter name: string) {
    this.name = name;
  }

  print(): void {
    console.log(this.name);
  }
}

let bob = new User2('Bob');
bob.setName('John');
bob.setName('Sam');
