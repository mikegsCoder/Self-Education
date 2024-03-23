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
