import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['../../../form-styles.css', './login.component.css'],
})
export class LoginComponent implements OnInit {
  isLoading = false;
  errorMessage = '';

  constructor(private userService: AuthService, private router: Router) {}

  ngOnInit(): void {}

  changeHandler(data: any): void {
    console.log(data);
  }

  submitFormHandler(formValue: { email: string; password: string }): void {
    this.isLoading = true;
    this.errorMessage = '';
    this.userService.login(formValue).subscribe({
      next: (data) => {
        this.isLoading = false;
        this.router.navigate(['/']);
      },
      error: (err) => {
        this.errorMessage = err.error.message;
        this.isLoading = false;
      },
    });
  }
}
