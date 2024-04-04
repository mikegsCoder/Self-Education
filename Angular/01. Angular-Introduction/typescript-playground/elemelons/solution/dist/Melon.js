"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Melon = void 0;
var Melon = (function () {
    function Melon(weight, melonSort) {
        this.weight = weight;
        this.melonSort = melonSort;
    }
    Object.defineProperty(Melon.prototype, "elementIndex", {
        get: function () {
            return this.weight * this.melonSort.length;
        },
        enumerable: false,
        configurable: true
    });
    return Melon;
}());
exports.Melon = Melon;
//# sourceMappingURL=Melon.js.map