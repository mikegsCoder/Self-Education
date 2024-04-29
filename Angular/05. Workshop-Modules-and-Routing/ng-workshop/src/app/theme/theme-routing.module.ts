import { Routes, RouterModule } from '@angular/router';

import { ThemeComponent } from './theme/theme.component';
import { NewComponent } from './new/new.component';
import { DetailComponent } from './detail/detail.component';

const routes: Routes = [
  {
    path: 'theme',
    pathMatch: 'full',
    component: ThemeComponent,
    data: {
      title: 'THEME'
    }
  },
  {
    path: 'theme/new',
    component: NewComponent,
    data: {
      title: 'NEW THEME'
    }
  },
  {
    path: 'theme/detail/:id',
    component: DetailComponent,
    data: {
      title: 'THEME DETAIL'
    }
  }
];


export const ThemeRouterModule = RouterModule.forChild(routes);
