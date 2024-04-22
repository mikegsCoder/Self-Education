import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './list/list.component';
import { DetailComponent } from './detail/detail.component';

const routes: Routes = [
  {
    path: 'user',
    redirectTo: 'user/list',
  },
  {
    path: 'user/list',
    component: ListComponent,
  },
  {
    path: 'user/detail/:id',
    component: DetailComponent
  }
];

export const UserRoutingModule = RouterModule.forChild(routes);
