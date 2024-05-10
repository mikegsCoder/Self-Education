import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list/list.component';
import { SharedModule } from '../shared/shared.module';
import { UserListResolver } from './user-list.resolver';

@NgModule({
  declarations: [ListComponent],
  providers: [UserListResolver],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class UserModule { }
