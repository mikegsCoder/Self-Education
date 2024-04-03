abstract class Employee {
  public name: string;
  public age: number;
  public salary: number;
  public tasks: string[];

  constructor(name: string, age: number) {
    this.name = name;
    this.age = age;
    this.salary = 0;
    this.tasks = [];	
  }

  public work(): void {
    const currentTask = this.tasks.shift();
    this.tasks.push(currentTask);
    console.log(this.name + currentTask);
  }

  public collectSalary(): void {
    console.log(`${this.name} received ${this.getSalary()} this month.`);
  }

  public getSalary(): number {
    return this.salary;
  }
}

export class Junior extends Employee {
	constructor(name: string, age: number) {
		super(name, age);
		this.tasks.push(' is working on a simple task.');
	}
}