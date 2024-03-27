import { Cloth } from './Cloth';

export class Magazine {
  type: string;
  capacity: number;
  clothes: Cloth[];

  constructor(type: string, capacity: number) {
    this.type = type;
    this.capacity = capacity;
    this.clothes = [];
  }

  addCloth(cloth: Cloth): void {
    if (this.clothes.length < this.capacity) {
      this.clothes.push(cloth);
    }
  }

  removeCloth(color: string): boolean {
    const index = this.clothes.findIndex((c) => c.color === color);

    if (index !== -1) {
      this.clothes.splice(index, 1);
      return true;
    }

    return false;
  }

  getSmallestCloth(): Cloth | undefined {
    return this.clothes.slice().sort((a, b) => a.size - b.size)[0];
  }

  getCloth(color: string): Cloth | undefined {
    return this.clothes.find((c) => c.color === color);
  }

  getClothCount(): number {
    return this.clothes.length;
  }

  report(): string {
    const sortedClothes = this.clothes.slice().sort((a, b) => a.size - b.size);

    const report = `${this.type} magazine contains:\n${sortedClothes
      .map((c) => c.toString())
      .join('\n')}`;

    return report;
  }
}
