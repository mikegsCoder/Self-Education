import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { AuthGuard } from './core/guards/auth.guard';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: '/home'
  },
  {
    path: 'home',
    component: HomeComponent,
    data: {
      title: 'HOME'
    }
  },
  {
    path: 'user',
    canActivateChild: [AuthGuard],
    loadChildren: () => import('./user/user.module').then(m => m.UserModule)
  },
  {
    path: 'theme',
    canActivateChild: [AuthGuard],
    loadChildren: () => import('./theme/theme.module').then(m => m.ThemeModule)
  },
  {
    path: '**',
    component: NotFoundComponent,
    data: {
      title: '404'
    }
  }
];

export const AppRoutingModule = RouterModule.forRoot(routes);
