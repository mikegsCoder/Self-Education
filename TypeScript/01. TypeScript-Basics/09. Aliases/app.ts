// ---------- aliases ----------
type id = number | string;

let userId: id = 2;
console.log(`Id: ${userId}`); // Id: 2

userId = 'qwerty';
console.log(`Id: ${userId}`); // Id: qwerty

// ---------- alias example ----------
// function parameter is alias
function printId(inputId: id) {
  console.log(`Id: ${inputId}`);
}
// return type is alias
function getId(isNumber: boolean): id {
  if (isNumber)
    return 1;
  else
    return '1';
}

printId(12345);
printId('qwerty');
console.log(getId(true));
