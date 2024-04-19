import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TestResolver } from './test.resolver';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent,
    resolve: [TestResolver],
  },
];

export const AppRoutingModule = RouterModule.forRoot(routes);
