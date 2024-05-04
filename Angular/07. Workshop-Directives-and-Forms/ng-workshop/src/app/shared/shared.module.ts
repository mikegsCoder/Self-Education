import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AsideComponent } from './aside/aside.component';
import { LoaderComponent } from './loader/loader.component';

@NgModule({
  declarations: [
    AsideComponent,
    LoaderComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    AsideComponent,
    LoaderComponent
  ]
})
export class SharedModule { }
