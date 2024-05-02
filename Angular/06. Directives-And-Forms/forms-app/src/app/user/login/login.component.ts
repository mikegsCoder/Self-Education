import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements AfterViewInit {

  @ViewChild('f', { static: false }) form: NgForm;

  defaultPassword = 123;

  loginHandler(formData) {
    console.log(formData);
  }

  ngAfterViewInit(): void {
    // setTimeout(() => {
    //   (this.form.controls as any).email.valueChanges.subscribe(console.log);
    // }, 0);

    this.form.valueChanges.subscribe(console.log);
  }
}
