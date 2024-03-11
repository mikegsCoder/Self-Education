/*
Create two generic interfaces:
 - Dealership that takes one generic type parameter: dealershipName
    and another property - soldCars (number)
 - Actions that takes one generic type parameter and defines a
    sellCar(dealerID , model) method, where both parameters are of
    the generic type passed to the interface

Create a class CarDealership that implements both Dealership and
    Actions and has one property of its own:
 - Public property modelsSold which is initially set to empty object

 Note: The dealershipName is taken through the constructor and the
    soldCars is initially set to 0.
Make the following two methods:
 - sellCar(dealerID , model)  – add the dealerID as a key and the
    model as value in the modelsSold object and increase the
    soldCars by 1;
 - showDetails() – return a message in the following format:

"{Dealership}:
{dealerID} sold {model}
..."
*/
var CarDealership = /** @class */ (function () {
    function CarDealership(dealershipName) {
        this.dealershipName = dealershipName;
        this.soldCars = 0;
        this.modelsSold = {};
    }
    CarDealership.prototype.sellCar = function (dealerID, model) {
        this.modelsSold[dealerID] = model;
        this.soldCars++;
    };
    CarDealership.prototype.showDetails = function () {
        var details = "".concat(this.dealershipName, ":\n");
        for (var dealerID in this.modelsSold) {
            details += "".concat(dealerID, " sold ").concat(this.modelsSold[dealerID], "\n");
        }
        return details;
    };
    return CarDealership;
}());
var dealership = new CarDealership("SilverStar");
dealership.sellCar("BG01", "C Class");
dealership.sellCar("BG02", "S Class");
dealership.sellCar("BG03", "ML Class");
dealership.sellCar("BG04", "CLK Class");
console.log(dealership.showDetails());
