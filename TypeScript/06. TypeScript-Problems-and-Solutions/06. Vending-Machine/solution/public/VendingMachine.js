"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.VendingMachine = void 0;
class VendingMachine {
    constructor(buttonCapacity) {
        this.buttonCapacity = buttonCapacity;
        this.drinks = [];
    }
    get getCount() {
        return this.drinks.length;
    }
    addDrink(drink) {
        if (this.drinks.length < this.buttonCapacity) {
            this.drinks.push(drink);
        }
    }
    removeDrink(name) {
        let index = this.drinks.findIndex((drink) => drink.name === name);
        if (index !== -1) {
            this.drinks.splice(index, 1);
            return true;
        }
        return false;
    }
    getLongest() {
        let drink = this.drinks.reduce((a, b) => (a.volume > b.volume ? a : b));
        return drink.toString();
    }
    getCheapest() {
        let drink = this.drinks.reduce((a, b) => (a.price < b.price ? a : b));
        return drink.toString();
    }
    buyDrink(name) {
        let index = this.drinks.findIndex((drink) => drink.name === name);
        if (index !== -1) {
            let drink = this.drinks[index];
            return drink.toString();
        }
        throw new Error('Invalid drink name');
    }
    report() {
        let result = 'Drinks available:\n';
        this.drinks.forEach((drink) => (result += drink.toString() + '\n'));
        return result.trim();
    }
}
exports.VendingMachine = VendingMachine;
