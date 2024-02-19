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
