import { Junior } from './Junior';
import { Senior } from './Senior';
import { Manager } from './Manager';

const junior = new Junior('Ivan', 25);
const senior = new Senior('Peter', 30);
const manager = new Manager('Dragan', 35);

junior.work();
senior.work();
manager.work();

junior.collectSalary();
senior.collectSalary();
manager.collectSalary();