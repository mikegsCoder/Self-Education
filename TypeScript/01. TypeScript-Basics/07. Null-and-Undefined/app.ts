// ---------- null and undefined ----------
let a: undefined = undefined;
let b: null = null;

// ---------- null and undefined example ----------
let userId: number | null = null;

function printId(id: number | null) {
  if (id === null) {
    console.log('No such user!');
  } else {
    console.log(`User id: ${id}.`);
  }
}

printId(userId);  // No such user!

userId = 34;
printId(userId);  // User id: 34.

// ---------- non-null assertion operator ----------
const header: HTMLElement | null = document.getElementById('header');
header!.innerText = 'Hello TypeScript!';
