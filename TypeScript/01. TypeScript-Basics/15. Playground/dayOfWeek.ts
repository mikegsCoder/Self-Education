// Write a simple function that prints some kind ot message when you pass day of week.

// ---------- solution ----------
enum dayOfWeek {
  sunday = 'You have to prepare for the next week.',
  monday = 'It\'s time to work.',
  tuesday = 'It\'s time to solve some TypeScript problems.',
  wednesday = 'You have to go to the gym.',
  thursday = 'You have some tasks arranged today.',
  friday = 'At least the weekend is so close.',
  saturday = 'It\'s time for a walk in the park.'
};

function dailyMessage(day: string) {
  if (dayOfWeek[day.toLocaleLowerCase()] === undefined) {
    console.log('Invalid day of week!');
  } else {
    console.log(dayOfWeek[day.toLocaleLowerCase()]);
  }
}

dailyMessage('SUNDay')    // You have to prepare for the next week.
dailyMessage('monDAY')    // It's time to work.
dailyMessage('Tuesday')   // It's time to solve some TypeScript problems.
dailyMessage('wednesday') // You have to go to the gym.
dailyMessage('thuRsday')  // You have some tasks arranged today.
dailyMessage('fridaY')    // At least the weekend is so close.
dailyMessage('saturday')  // It's time for a walk in the park.
dailyMessage('xyz')       // Invalid day of week!