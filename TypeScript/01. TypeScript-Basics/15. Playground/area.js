// Write simple function to calculate area for cube, rectangle, circle and triangle.
// ---------- solution ----------
function area(figure, a, b) {
    var resultMessage = 'The are of this figure is: ';
    if (figure.toLowerCase() === 'cube') {
        console.log(resultMessage + Math.pow(a, 2));
    }
    else if (figure.toLowerCase() === 'rectangle') {
        if (b === undefined) {
            console.log('You need to enter the second value!');
        }
        else {
            console.log(resultMessage + a * b);
        }
    }
    else if (figure.toLowerCase() === 'circle') {
        console.log(resultMessage + Math.PI * Math.pow(a, 2));
    }
    else if (figure.toLowerCase() === 'triangle') {
        if (b === undefined) {
            console.log('You need to enter the second value!');
        }
        else {
            console.log(resultMessage + a * b / 2);
        }
    }
    else {
        console.log('Invalid figure type!');
    }
}
area('cube', 2);
area('rectangle', 2, 4);
area('circle', 5);
area('triangle', 4, 6);
area('invalid', 4);
area('rectangle', 2);
area('triangle', 3);
