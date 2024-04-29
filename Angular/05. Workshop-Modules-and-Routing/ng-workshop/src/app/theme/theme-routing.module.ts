import { Routes, RouterModule } from '@angular/router';
import { ThemeComponent } from './theme/theme.component';

const routes: Routes = [
  {
    path: 'theme',
    pathMatch: 'full',
    component: ThemeComponent,
    data: {
      title: 'THEME'
    }
  },
];


export const ThemeRouterModule = RouterModule.forChild(routes);
