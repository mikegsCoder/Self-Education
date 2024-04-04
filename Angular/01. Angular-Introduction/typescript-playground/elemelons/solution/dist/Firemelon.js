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
exports.Firemelon = void 0;
var Melon_1 = require("./Melon");
var Firemelon = (function (_super) {
    __extends(Firemelon, _super);
    function Firemelon(weight, melonSort) {
        return _super.call(this, weight, melonSort) || this;
    }
    Firemelon.prototype.toString = function () {
        return 'Element: Fire' + '\n' + "Sort: ".concat(this.melonSort) + '\n' + "Element index: ".concat(this.elementIndex);
    };
    return Firemelon;
}(Melon_1.Melon));
exports.Firemelon = Firemelon;
//# sourceMappingURL=Firemelon.js.map