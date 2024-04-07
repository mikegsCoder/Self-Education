interface IMyObj {
  name: string;
  age: number;
  data: boolean[];
}

interface IMyObj2 extends IMyObj {
  test: string[]
}
