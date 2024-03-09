/*
Create three classes named Animal, Dog, and Cat. 
 - Animal with a single public method eat() that prints: "eating…"
 - Dog with a single public method bark() that prints: "barking…"
 - Cat with a single public method meow() that prints: "meowing…"
 - Dog and Cat should inherit from Animal.
*/

// ---------- solution ----------
class Animal {
  eat(): void {
    console.log('eating...');
  }
}

class Dog extends Animal {
  bark(): void {
    console.log('barking...');
  }
}

class Cat extends Animal {
  meow(): void {
    console.log('meowing...');
  }
}

const dog = new Dog();
const cat = new Cat();

dog.eat(); // eating...
dog.bark(); // barking...

cat.eat(); // eating...
cat.meow(); // meowing...
