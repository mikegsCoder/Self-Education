import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list/list.component';
import { SharedModule } from '../shared/shared.module';
import { UserListResolver } from './user-list.resolver';
import { UserRoutingModule } from './user-routing.module';

@NgModule({
  declarations: [ListComponent],
  providers: [UserListResolver],
  imports: [
    CommonModule,
    UserRoutingModule,
    SharedModule
  ]
})
export class UserModule { }
