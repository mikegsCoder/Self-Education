// ---------- interfaces ----------
interface IUser {
  id: number;
  name: string;
}

let employee1: IUser = {
  id: 1,
  name: 'Tom'
}

console.log('id: ', employee1.id);
console.log('name: ', employee1.name);

// ---------- interfaces as method and function parameters ----------
let employee2: IUser = {
  id: 2,
  name: 'Alice'
}

function printUser(user: IUser): void {
  console.log('id: ', user.id);
  console.log('name: ', user.name);
}

printUser(employee2);  
// id:  2
// name:  Alice

// ---------- interfaces as return type ----------
function buildUser(userId: number, userName: string): IUser {
  return { id: userId, name: userName };
}

let newUser = buildUser(3, 'Bill');

console.log('id: ', newUser.id);      // id:  3
console.log('name: ', newUser.name);  // name:  Bill

// ---------- optional properties ----------
interface IUserNew {
  id: number;
  name: string;
  age?: number;
}

let employee: IUserNew = {
  id: 1,
  name: 'Alice',
  age: 23
}

let manager: IUserNew = {
  id: 2,
  name: 'Tom'
}
