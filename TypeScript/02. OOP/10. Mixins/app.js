// ---------- mixins ----------
var Animal = /** @class */ (function () {
    function Animal() {
    }
    Animal.prototype.feed = function () {
        console.log('Feeding the animal.');
    };
    return Animal;
}());
var Movable = /** @class */ (function () {
    function Movable() {
        this.speed = 0;
    }
    Movable.prototype.move = function () {
        console.log('Moving');
    };
    return Movable;
}());
var Horse = /** @class */ (function () {
    function Horse() {
    }
    return Horse;
}());
function applyMixins(derivedCtor, baseCtors) {
    baseCtors.forEach(function (baseCtor) {
        Object.getOwnPropertyNames(baseCtor.prototype).forEach(function (name) {
            derivedCtor.prototype[name] = baseCtor.prototype[name];
        });
    });
}
applyMixins(Horse, [Animal, Movable]);
var pony = new Horse();
pony.feed(); // 
pony.move(); // 
// ----------  ----------
