// import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { UserListResolver } from './user-list.resolver';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: '/user/list'
  },
  {
    path: 'list',
    resolve: [UserListResolver],
    component: ListComponent
  }
];

export const UserRoutingModule = RouterModule.forChild(routes);
