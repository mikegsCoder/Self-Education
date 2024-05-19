import { createAction, props } from '@ngrx/store';

const userLoginNamespace = `[USER LOGIN]`;
export const userLoginSetLoading = createAction(`${userLoginNamespace} SET LOADING`, props<{ isLoading: boolean }>());
export const userLoginSetErrorMessage = createAction(`${userLoginNamespace} SET ERROR MESSAGE`, props<{ message: string }>());
