import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TestResolver } from './test.resolver';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent,
    resolve: { user: TestResolver }
  }
];

export const AppRoutingModule = RouterModule.forRoot(routes, { enableTracing: true });

