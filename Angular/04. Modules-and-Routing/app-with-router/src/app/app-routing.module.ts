import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { TestResolver } from './test.resolver';
import { AccessGuard } from './guards/access.guard';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent,
    resolve: [TestResolver],
  },
  {
    path: 'about',
    component: AboutComponent,
    canActivate: [AccessGuard],
    data: {
      isLogged: true,
    },
  },
];

export const AppRoutingModule = RouterModule.forRoot(routes);
