import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { ThemeService } from './theme.service';
import { SharedModule } from '../shared/shared.module';
import { PostModule } from '../post/post.module';
import { ThemeRouterModule } from './theme-routing.module';

import { ThemeListComponent } from './theme-list/theme-list.component';
import { ThemeListItemComponent } from './theme-list-item/theme-list-item.component';
import { ThemeComponent } from './theme/theme.component';
import { NewComponent } from './new/new.component';
import { DetailComponent } from './detail/detail.component';

@NgModule({
  declarations: [
    ThemeListComponent,
    ThemeListItemComponent,
    ThemeComponent,
    NewComponent,
    DetailComponent
  ],
  imports: [
    FormsModule,
    CommonModule,
    SharedModule,
    PostModule,
    ThemeRouterModule
  ],
  providers: [
    ThemeService
  ],
  exports: [
    ThemeListComponent,
    ThemeListItemComponent
  ]
})
export class ThemeModule { }
