class User {
  name: string;
  constructor(_name: string) {
    this.name = _name;
  }
}

const user: User = new User('Michael');
console.log('Hello, ', user.name + '!');
