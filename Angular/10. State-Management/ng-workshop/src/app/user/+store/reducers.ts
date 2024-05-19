import { createReducer, on } from '@ngrx/store';
import {
  userLoginSetErrorMessage,
  userLoginSetLoading,
  userRegisterSetLoading,
  userRegisterSetErrorMessage
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

export interface IRegisterState {
  errorMessage: string | null;
  isLoading: boolean;
}

export const initialRegisterState: IRegisterState = {
  errorMessage: null,
  isLoading: false
};

export const registerReducer = createReducer<IRegisterState>(
  initialRegisterState,
  on(userRegisterSetErrorMessage, (state, action) => {
    return { ...state, errorMessage: action.message };
  }),
  on(userRegisterSetLoading, (state, action) => {
    return { ...state, isLoading: action.isLoading };
  })
);
