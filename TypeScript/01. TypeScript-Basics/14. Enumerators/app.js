// ---------- enumerators ----------
var Season;
(function (Season) {
    Season[Season["Winter"] = 0] = "Winter";
    Season[Season["Spring"] = 1] = "Spring";
    Season[Season["Summer"] = 2] = "Summer";
    Season[Season["Autumn"] = 3] = "Autumn";
})(Season || (Season = {}));
;
// enum Season { Winter = 0, Spring = 1, Summer = 2, Autumn = 3 };
var current = Season.Summer;
console.log(current); // 2
current = Season.Autumn;
console.log(current); // 3
// ---------- enumerators example ----------
var currentSeason = Season[2];
console.log(currentSeason); // Summer
// ---------- enumerators example ----------
var Season1;
(function (Season1) {
    Season1["Winter"] = "It is snowing.";
    Season1["Spring"] = "My favourite season.";
    Season1["Summer"] = "It is time for beach.";
    Season1["Autumn"] = "The vacation is over.";
})(Season1 || (Season1 = {}));
;
var current1 = Season1.Spring;
console.log(current1); // My favourite season.
// ---------- enumerators in functions ----------
var DayTime;
(function (DayTime) {
    DayTime[DayTime["Morning"] = 0] = "Morning";
    DayTime[DayTime["Evening"] = 1] = "Evening";
})(DayTime || (DayTime = {}));
;
function welcome(dayTime) {
    if (dayTime === DayTime.Morning) {
        console.log('Good morning!');
    }
    else {
        console.log('Good evening!');
    }
}
var current2 = DayTime.Morning;
welcome(current2); // Good morning!
welcome(DayTime.Evening); // Good evening!
