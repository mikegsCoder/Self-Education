// write simple function that calculates Fibonacci sequence.
// ---------- solution ----------
function calcValue(input) {
    if (input < 1) {
        return 0;
    }
    if (input < 2) {
        return 1;
    }
    return calcValue(input - 2) + calcValue(input - 1);
}
;
function fibonacci(num) {
    var sequence = [];
    for (var n = 0; n < num; ++n) {
        var val = calcValue(n);
        sequence.push(val);
    }
    console.log('Fibonacci sequence: ' + sequence.join(', '));
}
fibonacci(5); // 
fibonacci(15); // 
