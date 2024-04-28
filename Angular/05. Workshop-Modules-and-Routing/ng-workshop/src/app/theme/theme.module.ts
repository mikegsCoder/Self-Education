import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ThemeService } from './theme.service';
import { SharedModule } from '../shared/shared.module';
import { PostModule } from '../post/post.module';
import { ThemeRouterModule } from './theme-routing.module';

import { ThemeListComponent } from './theme-list/theme-list.component';
import { ThemeListItemComponent } from './theme-list-item/theme-list-item.component';

@NgModule({
  declarations: [
    ThemeListComponent,
    ThemeListItemComponent,
  ],
  imports: [
    CommonModule,
    SharedModule,
    PostModule,
    ThemeRouterModule
  ],
  providers: [
    ThemeService
  ],
  exports: [
  ]
})
export class ThemeModule { }
