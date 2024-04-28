import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ThemeService } from './theme.service';
import { SharedModule } from '../shared/shared.module';
import { PostModule } from '../post/post.module';

@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    SharedModule,
    PostModule,
  ],
  providers: [
    ThemeService
  ],
  exports: [
  ]
})
export class ThemeModule { }
