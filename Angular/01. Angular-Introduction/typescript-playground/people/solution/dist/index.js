"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Junior_1 = require("./Junior");
var Senior_1 = require("./Senior");
var Manager_1 = require("./Manager");
var junior = new Junior_1.Junior('Ivan', 25);
var senior = new Senior_1.Senior('Peter', 30);
var manager = new Manager_1.Manager('Dragan', 35);
junior.work();
senior.work();
manager.work();
junior.collectSalary();
senior.collectSalary();
manager.collectSalary();
//# sourceMappingURL=index.js.map