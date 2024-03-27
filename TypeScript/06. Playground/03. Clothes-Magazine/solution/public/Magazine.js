"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Magazine = void 0;
class Magazine {
    constructor(type, capacity) {
        this.type = type;
        this.capacity = capacity;
        this.clothes = [];
    }
    addCloth(cloth) {
        if (this.clothes.length < this.capacity) {
            this.clothes.push(cloth);
        }
    }
    removeCloth(color) {
        const index = this.clothes.findIndex((c) => c.color === color);
        if (index !== -1) {
            this.clothes.splice(index, 1);
            return true;
        }
        return false;
    }
    getSmallestCloth() {
        return this.clothes.slice().sort((a, b) => a.size - b.size)[0];
    }
    getCloth(color) {
        return this.clothes.find((c) => c.color === color);
    }
    getClothCount() {
        return this.clothes.length;
    }
    report() {
        const sortedClothes = this.clothes.slice().sort((a, b) => a.size - b.size);
        const report = `${this.type} magazine contains:\n${sortedClothes
            .map((c) => c.toString())
            .join('\n')}`;
        return report;
    }
}
exports.Magazine = Magazine;
