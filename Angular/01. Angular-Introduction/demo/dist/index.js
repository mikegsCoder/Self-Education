"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var _ = require("underscore");
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
//# sourceMappingURL=index.js.map