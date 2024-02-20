// Write a simple function that prints some kind ot message when you pass day of week.
// ---------- solution ----------
var dayOfWeek;
(function (dayOfWeek) {
    dayOfWeek["sunday"] = "You have to prepare for the next week.";
    dayOfWeek["monday"] = "It's time to work.";
    dayOfWeek["tuesday"] = "It's time to solve some TypeScript problems.";
    dayOfWeek["wednesday"] = "You have to go to the gym.";
    dayOfWeek["thursday"] = "You have some tasks arranged today.";
    dayOfWeek["friday"] = "At least the weekend is so close.";
    dayOfWeek["saturday"] = "It's time for a walk in the park.";
})(dayOfWeek || (dayOfWeek = {}));
;
function dailyMessage(day) {
    if (dayOfWeek[day.toLocaleLowerCase()] === undefined) {
        console.log('Invalid day of week!');
    }
    else {
        console.log(dayOfWeek[day.toLocaleLowerCase()]);
    }
}
dailyMessage('SUNDay'); //
dailyMessage('monDAY'); //
dailyMessage('Tuesday'); //
dailyMessage('wednesday'); //
dailyMessage('thuRsday'); //
dailyMessage('fridaY'); //
dailyMessage('saturday'); //
dailyMessage('xyz'); //
