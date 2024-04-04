import { Melon } from './Melon';

export class Earthmelon extends Melon {
  constructor(weight: number, melonSort: string) {
    super(weight, melonSort);
  }

  public toString() {
    return 'Element: Earth' + '\n' + `Sort: ${this.melonSort}` + '\n' + `Element index: ${this.elementIndex}`;
  }
}