class Box<T> {
  private _boxes: T[] = [];

  public add(el: T) {
    this._boxes.push(el);
  }

  public remove() {
    this._boxes.shift();
  }

  public get count(): number {
    return this._boxes.length
  }
}

// let box = new Box<Number>();
// box.add(1);
// box.add(2);
// box.add(3);
// console.log(box.count);  // 3

let box = new Box<String>();
box.add("Pesho");
box.add("Gosho");
console.log(box.count);  // 2
box.remove();
console.log(box.count);  // 1
