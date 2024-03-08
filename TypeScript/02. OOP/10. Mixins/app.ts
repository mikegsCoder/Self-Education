// ---------- mixins - multiple inheritance ----------
class Animal {
  feed(): void {
    console.log('Feeding the animal.');
  }
}

class Movable {
  speed: number = 0;

  move(): void {
    console.log('Moving.');
  }
}

class Horse { }

interface Horse extends Animal, Movable { }

function applyMixins(derivedCtor: any, baseCtors: any[]) {
  baseCtors.forEach(baseCtor => {
    Object.getOwnPropertyNames(baseCtor.prototype).forEach(name => {
      derivedCtor.prototype[name] = baseCtor.prototype[name];
    });
  });
}

applyMixins(Horse, [Animal, Movable]);

let pony: Horse = new Horse();
pony.feed();  // Feeding the animal.
pony.move();  // Moving.
