// Create a class named Vehicle.
// The class should have public fields for:
// - Type: text
// - Brand: text
// - Color: text
// - MaxSpeed: integer number
// ---------- solution ----------
var Vehicle = /** @class */ (function () {
    function Vehicle(type, brand, color, maxSpeed) {
        this._type = type;
        this._brand = brand;
        this._color = color;
        this._maxSpeed = maxSpeed;
    }
    Vehicle.prototype.getType = function () {
        return this._type;
    };
    Vehicle.prototype.setType = function (newType) {
        this._type = newType;
    };
    Vehicle.prototype.getBrand = function () {
        return this._brand;
    };
    Vehicle.prototype.setBrand = function (newBrand) {
        this._brand = newBrand;
    };
    Vehicle.prototype.getColor = function () {
        return this._color;
    };
    Vehicle.prototype.setColor = function (newColor) {
        this._color = newColor;
    };
    Vehicle.prototype.getMaxSpeed = function () {
        return this._maxSpeed;
    };
    Vehicle.prototype.setMaxSpeed = function (newMaxSpeed) {
        this._maxSpeed = newMaxSpeed;
    };
    Vehicle.prototype.printInfo = function () {
        console.log("This vehicle is of type ".concat(this._type, " with brand ").concat(this._brand, ", color ").concat(this._color, " and has maximum speed of ").concat(this._maxSpeed, " km/h."));
    };
    return Vehicle;
}());
var landRover = new Vehicle('Jeep', 'Rover', 'Green', 250);
landRover.printInfo();
landRover.setColor('White');
landRover.setMaxSpeed(280);
landRover.printInfo();
