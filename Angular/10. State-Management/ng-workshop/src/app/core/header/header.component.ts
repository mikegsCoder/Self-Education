import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent {
  isLogged$ = this.authService.isLogged$;
  isReady$ = this.authService.isReady$;
  currentUser$ = this.authService.currentUser$;

  constructor(private authService: AuthService, private router: Router) {}

  logoutHandler(): void {
    this.authService
      .logout()
      .subscribe(() => this.router.navigate(['/user/login']));
  }
}
