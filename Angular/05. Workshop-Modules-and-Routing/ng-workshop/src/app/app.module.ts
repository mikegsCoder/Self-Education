import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { ThemeListComponent } from './theme-list/theme-list.component';
import { ThemeListItemComponent } from './theme-list-item/theme-list-item.component';
import { AsideComponent } from './aside/aside.component';
import { storageServiceProvider } from './storage.service';
import { UserService } from './user.service';
import { ThemeService } from './theme.service';
import { PostService } from './post.service';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    ThemeListComponent,
    ThemeListItemComponent,
    AsideComponent
  ],
  imports: [
    BrowserModule, 
    HttpClientModule
  ],
  providers: [
    storageServiceProvider, 
    UserService, 
    ThemeService, 
    PostService,
  ],
  bootstrap: [
    AppComponent, 
    HeaderComponent, 
    FooterComponent,
  ],
})
export class AppModule {}
