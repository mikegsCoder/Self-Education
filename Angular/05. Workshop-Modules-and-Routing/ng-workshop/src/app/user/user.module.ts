import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserService } from './user.service';
import { SharedModule } from '../shared/shared.module';
import { LoginComponent } from './login/login.component';
import { UserRoutingModule } from './user-routing.module';

@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    UserRoutingModule
  ],
  providers: [
    UserService
  ]
})
export class UserModule { }
