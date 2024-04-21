import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './list/list.component';

const routes: Routes = [
  {
    path: 'user',
    redirectTo: 'user/list',
  },
  {
    path: 'user/list',
    component: ListComponent,
  },
];

export const UserRoutingModule = RouterModule.forChild(routes);
