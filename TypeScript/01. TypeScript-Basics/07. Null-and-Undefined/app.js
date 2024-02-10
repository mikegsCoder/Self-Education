// ---------- null and undefined ----------
var a = undefined;
var b = null;
// ---------- null and undefined example ----------
var userId = null;
function printId(id) {
    if (id === null) {
        console.log('No such user!');
    }
    else {
        console.log("User id: ".concat(id, "."));
    }
}
printId(userId); // No such user!
userId = 34;
printId(userId); // User id: 34.
// ---------- non-null assertion operator ----------
var header = document.getElementById('header');
header.innerText = 'Hello TypeScript!';
