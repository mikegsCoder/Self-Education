import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { UserListResolver } from './user-list.resolver';
import { DetailComponent } from './detail/detail.component';

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
  },
  {
    path: 'detail/:id',
    component: DetailComponent
  }
];

export const UserRoutingModule = RouterModule.forChild(routes);
