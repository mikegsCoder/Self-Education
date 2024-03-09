/*
Create a generic class that has as a property an array of generic 
type. Create a compare(comparator) method that takes an argument of 
any type. Iterate through the array and compare each element of the 
array to the comparator and return how many times the comparator is 
matched.
*/

// ---------- solution 1 ----------
class CompareElements1<T> {
  private _arr: T[]

  constructor(arr: T[]) {
    this._arr = arr
  }

  compare(item: T): number {
    let counter: number = 0;
    this._arr.forEach(x => {
      if (x === item) {
        counter++
      }
    });

    return counter;
  }
}

let c1 = new CompareElements1(['a', 'b', 'ab', 'abc', 'cba', 'b']);
console.log(c1.compare('b'));  // 2

let d1 = new CompareElements1([1, 2, 3, 4, 5, 1, 1]);
console.log(d1.compare(1));  // 3
