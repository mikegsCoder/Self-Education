"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Watermelon_1 = require("./Watermelon");
var Melolemonmelon_1 = require("./Melolemonmelon");
var watermelon = new Watermelon_1.Watermelon(12.5, "Kingsize");
console.log(watermelon.toString());
var melolemonmelon = new Melolemonmelon_1.Melolemonmelon(15, "Alabala");
console.log(melolemonmelon.toString());
melolemonmelon.morph();
console.log(melolemonmelon.toString());
//# sourceMappingURL=index.js.map