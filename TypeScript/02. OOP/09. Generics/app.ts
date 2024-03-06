// ---------- generics ----------
function getId<T>(id: T): T {
  return id;
}

let result1 = getId<number>(5);
console.log(result1);  // 5

let result2 = getId<string>('abc');
console.log(result2);  // abc

// ---------- generic array ----------
function getString<T>(args: Array<T>): string {
  return args.join(', ');
}

let result3 = getString<number>([1, 2, 34, 5]);
console.log(result3);  // 1, 2, 34, 5

// ---------- generic class ----------
class User1<T> {
  private _id: T;

  constructor(id: T) {
    this._id = id;
  }

  getId(): T {
    return this._id;
  }
}

let tom = new User1<number>(3);
console.log(tom.getId());    // 3
// tom = new User1<string>("asd");  // Error!

let alice = new User1<string>('xyz');
console.log(alice.getId());  // xyz
