import * as _ from 'underscore';

import { test } from './other';

interface IMyObj {
  name: string;
  age: number;
  data: boolean[];
}

interface IMyObj2 extends IMyObj {
  test: string[]
}

class User {
  // name: string;
  // age: number;
  
  // constructor(name: string, age: number) {
  //   this.name = name;
  //   this.age = age;
  // }

  constructor(public name: string, public age: number){}

  returnInfo() {
    return {};
  }

  doSomething(obj: IMyObj) {
    return _.range(0, 10, 1);
  }

  doSomethingElse<T extends IMyObj>(obj: T): T {
    return obj;
  }
}

class Employee extends User {
  constructor(name: string, age: number) {
    super(name, age);
  }
}

const ivan = new User('Ivan', 20);

console.log(ivan.name);

ivan.doSomething({
  name: 'dasd',
  age: 20,
  data: []
});

const myObj: IMyObj2 = {
  name: 'asdsad',
  age: 25,
  test: ['as', 'df'],
  data: []
}

ivan.doSomethingElse<IMyObj2>(myObj);

console.log(test);