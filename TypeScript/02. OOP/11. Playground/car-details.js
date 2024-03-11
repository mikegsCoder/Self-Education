/*
Define two classes Car and Engine.
Car has the following properties:
 - Model
 - Weight
 - Color
Engine has the following properties:
 - Model
 - Power
 - Displacement
 - Efficiency
A Car’s weight and color and its Engine’s displacement and efficiency are optional.
Create a class Details that combines the data from both Car and Engine classes.
Your task is to print all the data about the cars in the format defined bellow.  Every indent is a tab.
Vehicle model: {CarModel}
Engine model: {EngineModel}
    Power: {EnginePower}
    Displacement: {EngineDisplacement}
    Efficiency: {EngineEfficiency}
Weight: {CarWeight}
Color: {CarColor}
If any of the optional fields is missing, print the info in the following format, where again the indent is a tab:
Your task is to print all the data about the cars in the format defined bellow.  Every indent is a tab.
Vehicle model: {CarModel}
Engine model: {EngineModel}
    Power: {EnginePower}
*/
// ---------- solution ----------
var Car = /** @class */ (function () {
    function Car(model, weight, color) {
        this.model = model;
        this.weight = weight;
        this.color = color;
    }
    return Car;
}());
var Engine = /** @class */ (function () {
    function Engine(model, power, displacement, efficiency) {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }
    return Engine;
}());
var Details = /** @class */ (function () {
    function Details(car, engine) {
        this.car = car;
        this.engine = engine;
        this.print();
    }
    Details.prototype.print = function () {
        var result = "Vehicle model: ".concat(this.car.model, "\nEngine model: ").concat(this.engine.model, "\n\tPower: ").concat(this.engine.power, "\n");
        if (this.engine.displacement)
            result += "\tDisplacement: ".concat(this.engine.displacement, "\n");
        if (this.engine.efficiency)
            result += "\tEfficiency: ".concat(this.engine.efficiency, "\n");
        if (this.car.weight)
            result += "Weight: ".concat(this.car.weight, "\n");
        if (this.car.color)
            result += "Color: ".concat(this.car.color, "\n");
        console.log(result);
    };
    return Details;
}());
var s = new Details(new Car('C class', 3982, 'red'), new Engine('MB177', 510, 3982, 'A'));
var t = new Details(new Car('C class'), new Engine('MB177', 510));
