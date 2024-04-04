import { Airmelon } from './Airmelon';

export class Melolemonmelon extends Airmelon {
  private elements: string[] = ['Water', 'Fire', 'Earth', 'Air'];
  
  constructor(weight: number, melonSort: string) {
    super(weight, melonSort);
  }

  public toString() {
    return `Element: ${this.elements[0]}` + '\n' + `Sort: ${this.melonSort}` + '\n' + `Element index: ${this.elementIndex}`;
  }

  public morph() {
    const currentElement = this.elements.shift();
    this.elements.push(currentElement);
  }
}