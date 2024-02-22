// Write a function that sorts a numeric array in ascending or descending order.
// ---------- solution ----------
function arrSort(arr, argument) {
    if (argument.toLocaleLowerCase() === 'ascending') {
        return arr.sort(function (n1, n2) { return n1 - n2; });
    }
    else if (argument.toLocaleLowerCase() === 'descending') {
        return arr.sort(function (n1, n2) { return n2 - n1; });
    }
    else {
        return arr;
    }
}
console.log(arrSort([3, -1, 0, 15, 7], 'ascending')); //
console.log(arrSort([3, -1, 0, 15, 7], 'descending')); //
console.log(arrSort([3, -1, 0, 15, 7], 'something')); //
