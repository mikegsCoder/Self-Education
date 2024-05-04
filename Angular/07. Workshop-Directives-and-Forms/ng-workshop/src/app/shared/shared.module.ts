import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AsideComponent } from './aside/aside.component';
import { LoaderComponent } from './loader/loader.component';
import { EmailValidatorDirective } from './email-validator.directive';

@NgModule({
  declarations: [
    AsideComponent,
    LoaderComponent,
    EmailValidatorDirective
  ],
  imports: [
    CommonModule
  ],
  exports: [
    AsideComponent,
    LoaderComponent,
    EmailValidatorDirective
  ]
})
export class SharedModule { }
