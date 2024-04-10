import { Component } from '@angular/core';

const users = [
  {
    firstName: 'Peter',
    lastName: 'Petrov',
    age: '30',
  },
  {
    firstName: 'George',
    lastName: 'Smith',
    age: '35',
  },
  {
    firstName: 'Ana',
    lastName: 'Nikol',
    age: '32',
  },
];

@Component({
  selector: 'app-root',
  //   template: `<div class="welcome-message">HELLO WORLD</div>`,
  //   styles:[
  //     `.welcome-message {color: red;}`
  //   ]
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  welcomeMessage = 'Hello!';
  users = users;

  constructor() {
    
  }

  nameInputBtnClickHandler(data: { inputEl: HTMLInputElement }): void {
    console.log(data.inputEl.value);
  }
}
