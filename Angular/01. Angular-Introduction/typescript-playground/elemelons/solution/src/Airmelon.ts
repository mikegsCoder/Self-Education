import { Melon } from './Melon';

export abstract class Airmelon extends Melon {
  constructor(weight: number, melonSort: string) {
    super(weight, melonSort);
  }

  public toString() {
    return 'Element: Air' + '\n' + `Sort: ${this.melonSort}` + '\n' + `Element index: ${this.elementIndex}`;
  }
}