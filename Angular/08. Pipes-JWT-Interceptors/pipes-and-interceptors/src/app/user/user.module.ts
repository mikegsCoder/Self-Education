import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { UserRoutingModule } from './user-routing.module';
import { ListComponent } from './list/list.component';
import { DetailComponent } from './detail/detail.component';
import { UserListResolver } from './user-list.resolver';

@NgModule({
  declarations: [ListComponent, DetailComponent],
  providers: [UserListResolver],
  imports: [CommonModule, UserRoutingModule, SharedModule],
})
export class UserModule {}
