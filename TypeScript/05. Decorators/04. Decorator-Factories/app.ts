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
