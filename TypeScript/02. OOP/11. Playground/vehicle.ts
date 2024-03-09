// Create a class named Vehicle with public fields for:
// - Type: text
// - Brand: text
// - Color: text
// - MaxSpeed: integer

// ---------- solution ----------
class Vehicle {
  private _type: string;
  private _brand: string;
  private _color: string;
  private _maxSpeed: number;

  constructor(type: string, brand: string, color: string, maxSpeed: number) {
    this._type = type;
    this._brand = brand;
    this._color = color;
    this._maxSpeed = maxSpeed;
  }

  getType(): string {
    return this._type
  }

  setType(newType: string) {
    this._type = newType;
  }

  getBrand(): string {
    return this._brand;
  }

  setBrand(newBrand: string): void {
    this._brand = newBrand;
  }

  getColor(): string {
    return this._color;
  }

  setColor(newColor: string): void {
    this._color = newColor;
  }

  getMaxSpeed(): number {
    return this._maxSpeed;
  }

  setMaxSpeed(newMaxSpeed: number): void {
    this._maxSpeed = newMaxSpeed;
  }

  printInfo(): void {
    console.log(`This vehicle is of type ${this._type} with brand ${this._brand}, color ${this._color} and has maximum speed of ${this._maxSpeed} km/h.`);
  }
}

const landRover = new Vehicle('Jeep', 'Rover', 'Green', 250);
landRover.printInfo();
// This vehicle is of type Jeep with brand Rover, color Green and has maximum speed of 250 km/h.

landRover.setColor('White');
landRover.setMaxSpeed(280);
landRover.printInfo();
// This vehicle is of type Jeep with brand Rover, color White and has maximum speed of 280 km/h.
