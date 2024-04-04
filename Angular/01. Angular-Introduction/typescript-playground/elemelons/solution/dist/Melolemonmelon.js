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
exports.Melolemonmelon = void 0;
var Airmelon_1 = require("./Airmelon");
var Melolemonmelon = (function (_super) {
    __extends(Melolemonmelon, _super);
    function Melolemonmelon(weight, melonSort) {
        var _this = _super.call(this, weight, melonSort) || this;
        _this.elements = ['Water', 'Fire', 'Earth', 'Air'];
        return _this;
    }
    Melolemonmelon.prototype.toString = function () {
        return "Element: ".concat(this.elements[0]) + '\n' + "Sort: ".concat(this.melonSort) + '\n' + "Element index: ".concat(this.elementIndex);
    };
    Melolemonmelon.prototype.morph = function () {
        var currentElement = this.elements.shift();
        this.elements.push(currentElement);
    };
    return Melolemonmelon;
}(Airmelon_1.Airmelon));
exports.Melolemonmelon = Melolemonmelon;
//# sourceMappingURL=Melolemonmelon.js.map