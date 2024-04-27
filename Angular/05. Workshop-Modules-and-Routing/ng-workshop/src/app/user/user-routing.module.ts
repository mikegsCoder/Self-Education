import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '../core/guards/auth.guard';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  {
    path: 'user',
    canActivateChild: [
      AuthGuard
    ],
    data: {
      testing: 123
    },
    children: [
      {
        path: 'login',
        component: LoginComponent,
        data: {
          isLogged: false,
          title: 'USER LOGIN'
        }
      },
      {
        path: 'register',
        component: RegisterComponent,
        data: {
          isLogged: false,
          noNavigation: true,
          title: 'REGISTER USER'
        },
      },
    ]
  }
];

export const UserRoutingModule = RouterModule.forChild(routes);
