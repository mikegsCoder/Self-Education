import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ThemeService } from './theme.service';
import { SharedModule } from '../shared/shared.module';
import { PostModule } from '../post/post.module';

import { ThemeListItemComponent } from './theme-list-item/theme-list-item.component';

@NgModule({
  declarations: [
    ThemeListItemComponent,
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
