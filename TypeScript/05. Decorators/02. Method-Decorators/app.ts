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
