var userId = 2;
console.log("Id: ".concat(userId)); // Id: 2
userId = 'qwerty';
console.log("Id: ".concat(userId)); // Id: qwerty
// ---------- alias example ----------
// function parameter is alias
function printId(inputId) {
    console.log("Id: ".concat(inputId));
}
// return type is alias
function getId(isNumber) {
    if (isNumber)
        return 1;
    else
        return '1';
}
printId(12345);
printId('qwerty');
console.log(getId(true));
