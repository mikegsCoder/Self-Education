import { ActionReducerMap } from '@ngrx/store';
import { IRootState } from 'src/app/+store';
import { ILoginState, IRegisterState, loginReducer, registerReducer} from './reducers';

export interface IUserState {
  readonly login: ILoginState;
  readonly register: IRegisterState;
}

export interface IUserModuleState extends IRootState {
  user: IUserState;
}

export const reducers: ActionReducerMap<IUserState> = {
  login: loginReducer,
  register: registerReducer
};
