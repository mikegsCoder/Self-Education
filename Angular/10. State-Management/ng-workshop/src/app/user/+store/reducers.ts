import { createReducer, on } from '@ngrx/store';
import {
  userLoginSetErrorMessage,
  userLoginSetLoading
} from './actions';

export interface ILoginState {
  errorMessage: string | null;
  isLoading: boolean;
}

export const initialLoginState: ILoginState = {
  errorMessage: null,
  isLoading: false
};

export const loginReducer = createReducer<ILoginState>(
  initialLoginState,
  on(userLoginSetErrorMessage, (state, action) => {
    return { ...state, errorMessage: action.message };
  }),
  on(userLoginSetLoading, (state, action) => {
    return { ...state, isLoading: action.isLoading };
  })
);
