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

// ---------- solution ----------
interface Dealership<T> {
  dealershipName: T;
  soldCars: Number;
}

interface Actions<T> {
  sellCar(dealerID: T, model: T)
}

class CarDealership<T extends string | number> implements Dealership<T>, Actions<T> {
  dealershipName: T;
  soldCars: number;
  modelsSold: Record<T, T>;

  constructor(dealershipName: T) {
    this.dealershipName = dealershipName;
    this.soldCars = 0;
    this.modelsSold = {} as Record<T, T>;
  }

  sellCar(dealerID: T, model: T): void {
    this.modelsSold[dealerID] = model;
    this.soldCars++;
  }

  showDetails(): string {
    let details = `${this.dealershipName}:\n`;
    for (const dealerID in this.modelsSold) {
      details += `${dealerID} sold ${this.modelsSold[dealerID]}\n`;
    }

    return details;
  }
}

let dealership = new CarDealership<string>("SilverStar");

dealership.sellCar("BG01", "C Class");
dealership.sellCar("BG02", "S Class");
dealership.sellCar("BG03", "ML Class");
dealership.sellCar("BG04", "CLK Class");

console.log(dealership.showDetails());
/*
SilverStar:        
BG01 sold C Class  
BG02 sold S Class  
BG03 sold ML Class 
BG04 sold CLK Class
*/