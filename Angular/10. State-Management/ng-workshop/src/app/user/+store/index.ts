import { ActionReducerMap } from '@ngrx/store';
import { IRootState } from 'src/app/+store';
import { ILoginState, loginReducer} from './reducers';

export interface IUserState {
  readonly login: ILoginState;
}

export interface IUserModuleState extends IRootState {
  user: IUserState;
}

export const reducers: ActionReducerMap<IUserState> = {
  login: loginReducer
};
