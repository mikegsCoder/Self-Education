// Write simple function to calculate area for cube, rectangle, circle and triangle.

// ---------- solution ----------
function area(figure: string, a: number, b?: number) {
  const resultMessage = 'The area of this figure is: ';

  if (figure.toLowerCase() === 'cube') {
    console.log(resultMessage + Math.pow(a, 2));
  } else if (figure.toLowerCase() === 'rectangle') {
    if (b === undefined) {
      console.log('You need to enter the second value!');
    } else {
      console.log(resultMessage + a * b!);
    }
  } else if (figure.toLowerCase() === 'circle') {
    console.log(resultMessage + Math.PI * Math.pow(a, 2));
  } else if (figure.toLowerCase() === 'triangle') {
    if (b === undefined) {
      console.log('You need to enter the second value!');
    } else {
      console.log(resultMessage + a * b! / 2);
    }
  } else {
    console.log('Invalid figure type!');
  }
}

area('cube', 2);         // The area of this figure is: 4
area('rectangle', 2, 4); // The area of this figure is: 8
area('circle', 5);       // The area of this figure is: 78.53981633974483
area('triangle', 4, 6);  // The area of this figure is: 12
area('invalid', 4);      // Invalid figure type!
area('rectangle', 2);    // You need to enter the second value!
area('triangle', 3);     // You need to enter the second value!
