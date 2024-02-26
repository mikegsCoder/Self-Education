// ---------- abstract class ----------
abstract class Figure1 {
}

// let someFigure = new Figure1()  // Error!

// ---------- abstract class example ----------
abstract class Figure2 {
  getArea(): void {
    console.log('Not Implemented!')
  }
}

class Rectangle2 extends Figure2 {
  constructor(public width: number, public height: number) {
    super();
  }

  getArea(): void {
    let square = this.width * this.height;
    console.log('area =', square);
  }
}

let someFigure2: Figure2 = new Rectangle2(20, 30)
someFigure2.getArea();   // area = 600

// ---------- abstract method ----------
abstract class Figure3 {
  abstract getArea(): void;
}

class Rectangle3 extends Figure3 {
  constructor(public width: number, public height: number) {
    super();
  }

  getArea(): void {
    let square = this.width * this.height;
    console.log('area =', square);
  }
}

let someFigure3: Figure3 = new Rectangle3(20, 30)
someFigure3.getArea();   // area = 600

// ---------- abstract field ----------
abstract class Figure4 {
  abstract x: number;
  abstract y: number;
  abstract getArea(): void;
}

class Rectangle4 extends Figure4 {
  //x: number;
  //y: number;

  constructor(public x: number, public y: number, public width: number, public height: number) {
    super();
  }

  getArea(): void {
    let square = this.width * this.height;
    console.log('area =', square);
  }
}

let someFigure: Figure4 = new Rectangle4(10, 10, 20, 25)
someFigure.getArea();   // area = 500
