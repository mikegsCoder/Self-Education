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
