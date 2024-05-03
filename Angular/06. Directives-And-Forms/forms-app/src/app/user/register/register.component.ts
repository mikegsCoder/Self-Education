import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  form: FormGroup;
  address: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      email: ['test@email.bg', [Validators.required, Validators.email], []],
      password: ['123456', [Validators.required, Validators.minLength(4)], []],
      address: this.fb.group({
        street: ['Test Street', [Validators.required, Validators.minLength(4)], []],
        postCode: ['9010', [Validators.required], []]
      })
    })
  }

  get addressForm() {
    return this.form.get('address') as FormGroup;
  }

  registerHandler() {
    
  }

  reset() {
    this.form.reset();
  }
}
