function regex(pattern: string) {
  let expression = new RegExp(pattern);

  return function regex(target: Object, propertyName: string) {
    let propertyValue = this[propertyName];

    // getter
    var getter = function () {
      return propertyValue;
    };

    // setter
    var setter = function (newVal: string) {
      let isValid: boolean = expression.test(newVal);

      if (isValid === false) {
        throw new Error(`Value ${newVal} does not match ${pattern}`);
      }
      else {
        console.log(`${newVal} is valid`);
      }
    };

    // remove property
    if (delete this[propertyName]) {
      // create new property with getter and setter
      Object.defineProperty(target, propertyName, {
        get: getter,
        set: setter
      });
    }
  }
}

class Account {
  @regex('^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$')
  email: string;

  @regex('^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$')
  phone: string;

  constructor(email: string, phone: string) {
    this.email = email;
    this.phone = phone;
  }
}

let acc = new Account('bir@gmail.com', '+23451235678');
// bir@gmail.com is valid
// +23451235678 is valid

acc.email = 'bir_iki_yedi';  // Error