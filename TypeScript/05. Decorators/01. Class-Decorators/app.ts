// ---------- class decorator ----------
function sealed(constructor: Function) {
  console.log('sealed decorator');
  Object.seal(constructor);
  Object.seal(constructor.prototype);
}

@sealed
class User1 {
  name: string;

  constructor(name: string) {
    this.name = name;
  }

  print(): void {
    console.log(this.name);
  }
}
