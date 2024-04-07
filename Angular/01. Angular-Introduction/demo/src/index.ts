interface IMyObj {
  name: string;
  age: number;
  data: boolean[];
}

interface IMyObj2 extends IMyObj {
  test: string[]
}

class User {
  name: string;
  age: number;
  
  constructor(name: string, age: number) {
    this.name = name;
    this.age = age;
  }
}