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

// ---------- solution ----------
abstract class Activities {
  abstract parkVehicle(plate: string): void;
  abstract payForStay(hours: number, rate: number, plate: string): void;
  abstract leaveTheParking(plate: string): void;
}

type ParkedVehicles = { plate: string, didPay: boolean }[];

class ParkingLot extends Activities {
  constructor(
    public capacity: number,
    public revenue = 0,
    public parkedVehicles: ParkedVehicles = []
  ) {
    super()
  }

  parkVehicle(plate: string) {
    if (this.capacity === this.parkedVehicles.length) {
      throw 'No more space!';
    }

    this.parkedVehicles.push({ plate, didPay: false });
  }

  payForStay(hours: number, rate: number, plate: string) {
    const item = this.parkedVehicles.find(i => i.plate === plate);

    if (!item) {
      throw 'Not found!';
    }

    this.revenue += rate * hours;
    item.didPay = true;
  }

  leaveTheParking(plate: string) {
    const item = this.parkedVehicles.find(i => i.plate === plate);
    if (!item) {
      throw 'Not found!';
    }

    if (item && !item.didPay) {
      throw 'You must pay!!!!!!'
    }

    this.parkedVehicles = this.parkedVehicles.filter(i => i.plate !== plate);
  }

  overview() {
    return `capacity: ${this.capacity}\nrevenue: ${this.revenue}\nparkedVehicles: ${this.parkedVehicles.map(i => `${i.plate} ${i.didPay}\n`)}`
  }
}

let p = new ParkingLot(5);
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
