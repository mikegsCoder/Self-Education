import { createReducer, on } from '@ngrx/store';
import { IUser } from '../shared/interfaces';
import { login } from './actions';

export interface IAuthState {
  currentUser: IUser | null | undefined;
}

export const initialState: IAuthState = {
  currentUser: undefined
};

const setCurrentUser = (
  state: IAuthState,
  action: ReturnType<typeof login>    
) => {
  return { ...state, currentUser: action.user };
};

export const authReducer = createReducer<IAuthState>(
  initialState,
  on(login, setCurrentUser)
);
