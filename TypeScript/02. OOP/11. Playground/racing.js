/*
Create an interface Racing which declares three functions:
1.	createRacer(name, fuel, position). The name is a string and the
    fuel and position are numbers.
2.	consumeFuel(usedFuel, name). The used fuel is a number and the
    name is a string.
3.	overtake(gained, lost). The gained property is the name of the
    racer which gained a position and the lost – the name of the
    driver who lost position.
Create a class Circuit which implements the Racing interface.
    The class should have a public property racers which is set to
    empty array through the constructor. Implement the following
    functionality of the functions declared in the interface and
    create a new one – showPositions():
1.	createRacer(name, fuel, position). Create an object with the
    parameters passed in the method in the following format:
    { name, fuel, position } and add it to the racers array
2.	consumeFuel(usedFuel, name). Find the racer with the name passed
    in the method and subtract the used fuel from the property fuel
    you created in the previous method. If the fuel is equal or less
    than 0 create an additional property to the driver – isDNF and
    set its value to “true”
3.	overtake(gained, lost) If both racers that are passed to the
    method are valid (are in the racers array), not disqualified and
    the racer who gains the positions is not ahead of the one losing
    it you should increase the value of the position property of the
    racer who lost and decrease the value to the one who gained.
    Furthermore, if the racer who lost position is already in last
    place you should return the following message: “${racerName} is
    on the back of the grid!”
4.	showPositions(). You should sort the racers in ascending order by
    their position and display them in the following order without
    the disqualified drivers:
•	{racerName} finished on {position} position with {fuel} l remaining
•	{racerName} finished on {position} position with {fuel} l remaining
•	...
*/
var Circuit = /** @class */ (function () {
    function Circuit(racers) {
        if (racers === void 0) { racers = []; }
        this.racers = racers;
    }
    Circuit.prototype.createRacer = function (name, fuel, position) {
        var alreadyCreated = false;
        var existing = this.racers.filter(function (x) { return x.name === name; }).length != 0;
        if (!existing) {
            this.racers.push({ name: name, fuel: fuel, position: position, isDNF: false });
        }
    };
    Circuit.prototype.consumeFuel = function (usedFuel, name) {
        this.racers.forEach(function (i) {
            if (i.name === name) {
                if (i.fuel <= usedFuel) {
                    i.isDNF = true;
                    i.fuel = 0;
                    return;
                }
                i.fuel -= usedFuel;
            }
        });
    };
    Circuit.prototype.overtake = function (gained, lost) {
        var racerGained = {};
        var racerLost = {};
        var lastPlace = -Infinity;
        this.racers.forEach(function (i) {
            if (i.name === gained)
                racerGained = i;
            if (i.name === lost)
                racerLost = i;
            if (lastPlace < i.position)
                lastPlace = i.position;
        });
        if (this.instanceOfRacer(racerGained) && !racerGained.isDNF &&
            this.instanceOfRacer(racerLost) && !racerLost.isDNF) {
            if (lastPlace === racerLost.position) {
                return "".concat(racerLost.name, " is on the back of the grid!");
            }
            if (racerGained.position > racerLost.position) {
                var swapPosition = racerLost.position;
                racerLost.position = racerGained.position;
                racerGained.position = swapPosition;
            }
        }
    };
    Circuit.prototype.instanceOfRacer = function (object) {
        return 'isDNF' in object;
    };
    Circuit.prototype.showPositions = function () {
        var result = '';
        this.racers
            .sort(function (a, b) { return a.position - b.position; })
            .forEach(function (i) { return result += "".concat(i.name, " finished on ").concat(i.position, " with ").concat(i.fuel, " l remaining\n"); });
        return result;
    };
    return Circuit;
}());
var race = new Circuit();
race.createRacer('LH', 100, 1);
race.createRacer('LH', 100, 4);
race.createRacer('VB', 100, 2);
race.createRacer('DR', 100, 3);
// console.log(race.racers);
race.consumeFuel(92, 'LH');
// race.consumeFuel(9, 'LH');
race.consumeFuel(87, 'VB');
race.consumeFuel(89, 'DR');
// console.log(race.racers);
race.overtake('LH', 'VB');
race.overtake('DR', 'VB');
console.log(race.overtake('LH', 'VB'));
// console.log(race.racers);
console.log(race.showPositions());
// VB is on the back of the grid!
// LH finished on 1 with 8 l remaining
// DR finished on 2 with 11 l remaining
// VB finished on 3 with 13 l remaining
