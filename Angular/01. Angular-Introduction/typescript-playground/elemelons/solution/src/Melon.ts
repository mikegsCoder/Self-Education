export abstract class Melon {
  public weight: number;
  public melonSort: string;

  constructor(weight: number, melonSort: string) {
    this.weight = weight;
    this.melonSort = melonSort;
  }

  public get elementIndex(){
    return this.weight * this.melonSort.length;
  }
}