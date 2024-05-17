import { createAction, props } from '@ngrx/store';
import { IUser } from '../shared/interfaces';

const authNamespace = `[AUTH]`;

export const login = createAction(`${authNamespace} Login`, props<{ user: IUser }>());
