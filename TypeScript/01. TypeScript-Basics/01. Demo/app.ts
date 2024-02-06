class User {
  name: string;
  constructor(_name: string) {
    this.name = _name;
  }
}

const user: User = new User('Michael');
const header = this.document.getElementById('header');

header!.innerHTML = 'Hello, ' + user.name + '!';
