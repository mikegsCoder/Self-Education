// ---------- union ----------
var id1;
id1 = "1345dgg5";
console.log(id1); // 1345dgg5
id1 = 234;
console.log(id1); // 234
// ---------- union as function parameter example ----------
function printId(id2) {
    console.log("Id: ".concat(id2));
}
var id2 = 'xyz123';
printId('1h2e3l4o5');
printId(9876);
printId(id2);
