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

// ---------- solution ----------
interface Racing {
  createRacer(name: string, fuel: number, position: number): void;
  consumeFuel(usedFuel: number, name: string): void;
  overtake(gained: string, lost: string): void;
}

type Racer = {
  name: string;
  fuel: number;
  position: number;
  isDNF: boolean;
}

class Circuit implements Racing {
  public racers: Racer[];

  constructor(racers: Racer[] = []) {
    this.racers = racers;
  }

  createRacer(name: string, fuel: number, position: number) {
    let alreadyCreated: boolean = false;

    const existing = this.racers.filter(x => x.name === name).length != 0;

    if (!existing) {
      this.racers.push({ name, fuel, position, isDNF: false });
    }
  }

  consumeFuel(usedFuel: number, name: string) {
    this.racers.forEach(i => {
      if (i.name === name) {
        if (i.fuel <= usedFuel) {
          i.isDNF = true;
          i.fuel = 0;
          return;
        }

        i.fuel -= usedFuel;
      }
    })
  }

  overtake(gained: string, lost: string) {
    let racerGained: Racer | {} = {};
    let racerLost: Racer | {} = {};
    let lastPlace: number = -Infinity;

    this.racers.forEach(i => {
      if (i.name === gained) racerGained = i;
      if (i.name === lost) racerLost = i;
      if (lastPlace < i.position) lastPlace = i.position;
    });

    if (this.instanceOfRacer(racerGained) && !racerGained.isDNF &&
      this.instanceOfRacer(racerLost) && !racerLost.isDNF) {
      if (lastPlace === racerLost.position) {
        return `${racerLost.name} is on the back of the grid!`;
      }

      if (racerGained.position > racerLost.position) {
        const swapPosition = racerLost.position;

        racerLost.position = racerGained.position;
        racerGained.position = swapPosition;
      }
    }

  }

  instanceOfRacer(object: any): object is Racer {
    return 'isDNF' in object;
  }

  showPositions(): string {
    let result: string = '';

    this.racers
      .sort((a, b) => a.position - b.position)
      .forEach((i) => result += `${i.name} finished on ${i.position} with ${i.fuel} l remaining\n`);

    return result;
  }
}

const race = new Circuit();
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