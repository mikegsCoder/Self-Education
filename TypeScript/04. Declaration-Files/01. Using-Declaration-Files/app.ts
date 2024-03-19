/// <reference path='globals.d.ts' />

console.log(message);

hello();

let result = sum(2, 5);
console.log(result);

tom.print();

for (let point of points) {
  console.log(`Point with coordinates X = ${point.X}, Y = ${point.Y}`);
}

let bob = new Person('Bob', 37);
bob.display();          // Bob 37
console.log(bob.name);  // Bob