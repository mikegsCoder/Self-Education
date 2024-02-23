// ---------- classes ----------
class User1 {
  name: string;
  age: number;
}

let tom = new User1();
tom.name = 'Tom';
tom.age = 36;

console.log(`name: ${tom.name}  age: ${tom.age}`);  // name: Tom  age: 36

// ---------- classes example ----------
class User2 {
  name: string = 'Tom Smith';
  age: number = 43;
}

let user = new User2();

console.log(`name: ${user.name}  age: ${user.age}`);   // name: Tom Smith  age: 43
