// ---------- enumerators ----------
enum Season { Winter, Spring, Summer, Autumn };
// enum Season { Winter = 0, Spring = 1, Summer = 2, Autumn = 3 };

let current: Season = Season.Summer;
console.log(current);  // 2

current = Season.Autumn;
console.log(current);  // 3

// ---------- enumerators example ----------
var currentSeason: string = Season[2];
console.log(currentSeason);  // Summer
