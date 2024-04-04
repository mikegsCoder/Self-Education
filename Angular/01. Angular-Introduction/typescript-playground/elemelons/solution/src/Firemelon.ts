import { Melon } from './Melon';

export class Firemelon extends Melon {
  constructor(weight: number, melonSort: string) {
    super(weight, melonSort);
  }

  public toString() {
    return 'Element: Fire' + '\n' + `Sort: ${this.melonSort}` + '\n' + `Element index: ${this.elementIndex}`;
  }
}