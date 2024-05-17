import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Store } from '@ngrx/store';
import { BehaviorSubject, Observable } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { IUser } from '../shared/interfaces';
import { IRootState } from '../+store';
import { login, register } from '../+store/actions';

@Injectable()
export class AuthService {

  private _currentUser: BehaviorSubject<IUser | null> = new BehaviorSubject(undefined);
  currentUser$ = this.store.select((state) => state.auth.currentUser);
  isLogged$ = this.currentUser$.pipe(map(currentUser => currentUser !== null));
  isReady$ = this.currentUser$.pipe(map(currentUser => currentUser !== undefined));

  constructor(
    private http: HttpClient,
    private store: Store<IRootState>
  ) { }

  updateCurrentUser(user: IUser | null): void {
    this._currentUser.next(user);
  }

  login(data: any): Observable<any> {
    return this.http.post(`/users/login`, data).pipe(
      tap((user: IUser) => this.store.dispatch(login({ user })))
    );
  }

  register(data: any): Observable<any> {
    return this.http.post(`/users/register`, data).pipe(
      tap((user: IUser) => this.store.dispatch(register({ user })))
    );
  }

  logout(): Observable<any> {
    return this.http.post(`/users/logout`, {}).pipe(
      tap((user: IUser) => this._currentUser.next(null))
    );
  }

  authenticate(): Observable<any> {
    return this.http.get(`/users/profile`).pipe(
      tap((user: IUser) => this._currentUser.next(user)),
      catchError(() => {
        this._currentUser.next(null);
        return [null];
      })
    );
  }
}
