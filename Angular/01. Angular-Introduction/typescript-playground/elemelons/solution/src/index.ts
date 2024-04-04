import { Watermelon } from './Watermelon';
import { Firemelon } from './Firemelon';
import { Earthmelon } from './Earthmelon';
import { Airmelon } from './Airmelon';
import { Melolemonmelon } from './Melolemonmelon';

let watermelon : Watermelon = new Watermelon(12.5, "Kingsize");
console.log(watermelon.toString());
// Element: Water
// Sort: Kingsize
// Element index: 100

let melolemonmelon : Melolemonmelon = new Melolemonmelon (15, "Alabala");
console.log(melolemonmelon.toString());
// Element: Water
// Sort: Alabala
// Element index: 105

melolemonmelon.morph();
console.log(melolemonmelon.toString());
// Element: Fire
// Sort: Alabala
// Element index: 105