/*
Create an abstract class Activities which declares three abstract methods:
1.	parkVehicle(plate). The plate is of a string type.
2.	payForStay(hours, rate, plate). The hours and rate parameters
    are numbers and the plate is a string.
3.	leaveTheParking(plate). The plate is of a string type.
Create a class ParkingLot which extends the Activities class. The
    class should have a public properties capacity, which is set
    through the constructor, revenue – a number set to 0 and
    parkedVehicles – an empty array. Implement the following
    functionality of the methods declared in the abstract and
    create a new one – overview():
1.	parkVehicle(plate). If there is enough capacity for the new
    vehicle push in into the parkedVehicles array with an object in
    the following format: { plate, didPay } Please note that the
    didPay must be originally set to false! Otherwise, throw a new
    error “No more available spaces in the parking lot!”
2.	payForStay(hours, rate, plate). Check if the vehicles is parked
    and if it is it you should increase the revenue with the
    derivative of rate and hours and change the didPay to true.
    However, if the vehicles is not parked, throw a new error
    “There is no such vehicle parked in the parking lot!”
3.	leaveTheParking(plate). Check if the vehicle is parked and it
    paid for the stay. If so remove it from the parkedVehicles array.
4.	overview() - You should display the revenue and the remaining
    parked vehicles in the parking lot, separated by comma and space,
    in the following format:
 - The current revenue of the parking lot is {revenue} and {parkedVehicles} are parked
*/
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
// ---------- solution ----------
var Activities = /** @class */ (function () {
    function Activities() {
    }
    return Activities;
}());
var ParkingLot = /** @class */ (function (_super) {
    __extends(ParkingLot, _super);
    function ParkingLot(capacity, revenue, parkedVehicles) {
        if (revenue === void 0) { revenue = 0; }
        if (parkedVehicles === void 0) { parkedVehicles = []; }
        var _this = _super.call(this) || this;
        _this.capacity = capacity;
        _this.revenue = revenue;
        _this.parkedVehicles = parkedVehicles;
        return _this;
    }
    ParkingLot.prototype.parkVehicle = function (plate) {
        if (this.capacity === this.parkedVehicles.length) {
            throw "No more space!";
        }
        this.parkedVehicles.push({ plate: plate, didPay: false });
    };
    ParkingLot.prototype.payForStay = function (hours, rate, plate) {
        var item = this.parkedVehicles.find(function (i) { return i.plate === plate; });
        if (!item) {
            throw "Not found!";
        }
        this.revenue += rate * hours;
        item.didPay = true;
    };
    ParkingLot.prototype.leaveTheParking = function (plate) {
        var item = this.parkedVehicles.find(function (i) { return i.plate === plate; });
        if (!item) {
            throw "Not found!";
        }
        if (item && !item.didPay) {
            throw "You must pay!!!!!!";
        }
        this.parkedVehicles = this.parkedVehicles.filter(function (i) { return i.plate !== plate; });
    };
    ParkingLot.prototype.overview = function () {
        return "capacity: ".concat(this.capacity, "\nrevenue: ").concat(this.revenue, "\nparkedVehicles: ").concat(this.parkedVehicles.map(function (i) { return "".concat(i.plate, " ").concat(i.didPay, "\n"); }));
    };
    return ParkingLot;
}(Activities));
var p = new ParkingLot(5);
p.parkVehicle('CA1111CA');
p.parkVehicle('CA2222CA');
p.parkVehicle('CA3333CA');
p.parkVehicle('CA4444CA');
p.parkVehicle('CA5555CA');
p.payForStay(4, 2, 'CA1111CA');
p.payForStay(2, 2, 'CA2222CA');
p.payForStay(7, 2, 'CA4444CA');
p.leaveTheParking('CA1111CA');
p.leaveTheParking('CA4444CA');
console.log(p.overview());
