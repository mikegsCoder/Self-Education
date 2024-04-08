"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var _ = require("underscore");
var other_1 = require("./other");
var User = (function () {
    function User(name, age) {
        this.name = name;
        this.age = age;
    }
    User.prototype.returnInfo = function () {
        return {};
    };
    User.prototype.doSomething = function (obj) {
        return _.range(0, 10, 1);
    };
    User.prototype.doSomethingElse = function (obj) {
        return obj;
    };
    return User;
}());
var Employee = (function (_super) {
    __extends(Employee, _super);
    function Employee(name, age) {
        return _super.call(this, name, age) || this;
    }
    return Employee;
}(User));
var ivan = new User('Ivan', 20);
console.log(ivan.name);
ivan.doSomething({
    name: 'dasd',
    age: 20,
    data: []
});
var myObj = {
    name: 'asdsad',
    age: 25,
    test: ['as', 'df'],
    data: []
};
ivan.doSomethingElse(myObj);
console.log(other_1.test);
//# sourceMappingURL=index.js.map