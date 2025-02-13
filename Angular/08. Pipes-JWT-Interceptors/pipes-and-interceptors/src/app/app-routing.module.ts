import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { AccessGuard } from './guards/access.guard';
import { TestResolver } from './test.resolver';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent,
    resolve: { user: TestResolver }
  },
  {
    path: 'about',
    canActivate: [AccessGuard],
    component: AboutComponent,
    data: {
      isLogged: true
    }
  },
  {
    path: 'user',
    loadChildren: () => import('./user/user.module').then(m => m.UserModule)
  }
];

export const AppRoutingModule = RouterModule.forRoot(routes, { enableTracing: true });

