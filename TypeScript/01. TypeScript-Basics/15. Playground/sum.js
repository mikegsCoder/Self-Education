// Write a simple function to sum numbers from m to n.
// ---------- solution: ----------
function sum(m, n) {
    var resultMessage = 'The sum is ';
    if (m == n) {
        console.log(resultMessage + m);
    }
    else {
        var min = Math.min(m, n);
        var max = Math.max(m, n);
        var sum_1 = 0;
        for (var i = min; i <= max; i++) {
            sum_1 += i;
        }
        console.log(resultMessage + sum_1);
    }
}
sum(2, 4);
sum(-2, 2);
sum(3, 3);
