// import { CanActivateFn } from '@angular/router';

// export const accessGuard: CanActivateFn = (route, state) => {
//   return true;
// };

import { Route } from '@angular/router';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable()
export class AccessGuard implements CanActivate {
  constructor(private router: Router) {
    
  }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {

    // const isUserLogged = this.authService.isLogged;
    // const routerIsLogged = next.data.isLogged;
    // const result = routerIsLogged ? isUserLogged : true;
    // if (!result) {
    //   this.router.navigateByUrl(this.router.url === 'about' ? '/' : this.router.url);
    // }
    // return result;
    return true;
  }
}