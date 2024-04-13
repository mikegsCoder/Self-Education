import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent {
  get isLogged(): boolean {
    return false;
  }

  constructor() {}

  loginHandler(): void {}

  logoutHandler(): void {}
}
