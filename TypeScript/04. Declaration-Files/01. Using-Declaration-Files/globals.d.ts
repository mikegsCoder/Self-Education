// declare variable:
declare let message: string;

// declare functions:
declare function hello(): void;
declare function sum(a: number, b: number): number;

// declare object:
declare const tom: { name: string, age: number, print: () => void };

// declare complex object:
interface IPoint {
  X: number;
  Y: number;
}

declare var points: IPoint[];

// declare class:
declare class Person {
  name: string;
  age: number;
  constructor(name: string, age: number);
  display(): void;
}