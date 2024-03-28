// tsc && node .\dist\index.js
function printAndSum(start, end) {
    let sum = 0;
    let numbers = [];
    for (let number = start; number <= end; number++) {
        sum += number;
        numbers.push(number);
    }
    console.log(numbers.join(' '));
    console.log(`Sum: ${sum}`);
}
printAndSum(5, 10);
printAndSum(0, 26);
printAndSum(50, 60);
