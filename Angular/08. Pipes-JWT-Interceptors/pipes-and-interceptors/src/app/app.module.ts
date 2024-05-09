import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { SharedModule } from './shared/shared.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';

import { AccessGuard } from './guards/access.guard';
import { TestResolver } from './test.resolver';

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    SharedModule,
    CoreModule,
  ],
  providers: [
    AccessGuard,
    TestResolver
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
