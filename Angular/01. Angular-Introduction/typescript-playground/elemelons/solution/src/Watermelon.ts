import { Melon } from './Melon';

export class Watermelon extends Melon {
  constructor(weight: number, melonSort: string) {
    super(weight, melonSort);
  }

  public toString() {
    return 'Element: Water' + '\n' + `Sort: ${this.melonSort}` + '\n' + `Element index: ${this.elementIndex}`;
  }
}