import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

import { HeaderComponent } from './core/header/header.component';
import { FooterComponent } from './core/footer/footer.component';
import { NotFoundComponent } from './not-found/not-found.component';

import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { PostModule } from './post/post.module';
import { ThemeModule } from './theme/theme.module';
import { UserModule } from './user/user.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NotFoundComponent,
  ],
  imports: [
    BrowserModule, 
    HttpClientModule,
    AppRoutingModule,
    PostModule.forRoot(),
    ThemeModule,
    UserModule,
    CoreModule,
  ],
  providers: [
  ],
  bootstrap: [
    AppComponent, 
    HeaderComponent, 
    FooterComponent,
  ],
})

export class AppModule {}
