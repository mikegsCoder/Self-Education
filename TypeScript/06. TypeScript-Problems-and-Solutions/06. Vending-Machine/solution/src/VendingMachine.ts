import { Drink } from './Drink';

export class VendingMachine {
  private buttonCapacity: number;
  private drinks: Drink[];

  constructor(buttonCapacity: number) {
    this.buttonCapacity = buttonCapacity;
    this.drinks = [];
  }

  get getCount(): number {
    return this.drinks.length;
  }

  addDrink(drink: Drink): void {
    if (this.drinks.length < this.buttonCapacity) {
      this.drinks.push(drink);
    }
  }

  removeDrink(name: string): boolean {
    let index = this.drinks.findIndex((drink) => drink.name === name);

    if (index !== -1) {
      this.drinks.splice(index, 1);

      return true;
    }

    return false;
  }

  getLongest(): string {
    let drink = this.drinks.reduce((a, b) => (a.volume > b.volume ? a : b));

    return drink.toString();
  }

  getCheapest(): string {
    let drink = this.drinks.reduce((a, b) => (a.price < b.price ? a : b));

    return drink.toString();
  }

  buyDrink(name: string): string {
    let index = this.drinks.findIndex((drink) => drink.name === name);

    if (index !== -1) {
      let drink = this.drinks[index];

      return drink.toString();
    }

    throw new Error('Invalid drink name');
  }

  report(): string {
    let result = 'Drinks available:\n';
    this.drinks.forEach((drink) => (result += drink.toString() + '\n'));

    return result.trim();
  }
}
