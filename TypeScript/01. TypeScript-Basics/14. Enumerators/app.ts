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

// ---------- enumerators example ----------
enum Season1 {
  Winter = 'It is snowing.',
  Spring = 'My favourite season.',
  Summer = 'It is time for beach.',
  Autumn = 'The vacation is over.'
};

var current1: Season1 = Season1.Spring;
console.log(current1);  // My favourite season.

// ---------- enumerators in functions ----------
enum DayTime {
  Morning,
  Evening
};

function welcome(dayTime: DayTime) {

  if (dayTime === DayTime.Morning) {
    console.log('Good morning!');
  }
  else {
    console.log('Good evening!');
  }
}

let current2: DayTime = DayTime.Morning;
welcome(current2);           // Good morning!
welcome(DayTime.Evening);    // Good evening!

// ---------- enumerators in functions example: ----------
enum DayTimeMessage {
  Morning = 'Good morning!',
  Evening = 'Good evening!'
};

function welcome1(message: DayTimeMessage) {
  console.log(message);
}

let messsage: DayTimeMessage = DayTimeMessage.Morning;
welcome1(messsage);                // Good morning!
welcome1(DayTimeMessage.Evening);  // Good evening!
