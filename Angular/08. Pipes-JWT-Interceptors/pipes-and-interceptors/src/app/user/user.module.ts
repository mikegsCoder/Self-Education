import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list/list.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [ListComponent],
  providers: [],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class UserModule { }
