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
