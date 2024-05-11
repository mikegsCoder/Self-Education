import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list/list.component';
import { SharedModule } from '../shared/shared.module';
import { UserListResolver } from './user-list.resolver';
import { UserRoutingModule } from './user-routing.module';
import { DetailComponent } from './detail/detail.component';

@NgModule({
  declarations: [ListComponent, DetailComponent],
  providers: [UserListResolver],
  imports: [CommonModule, UserRoutingModule, SharedModule],
})
export class UserModule {}
