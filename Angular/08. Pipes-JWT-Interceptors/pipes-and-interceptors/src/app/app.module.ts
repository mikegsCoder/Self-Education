import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';

import { AccessGuard } from './guards/access.guard';
import { TestResolver } from './test.resolver';

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    CoreModule,
  ],
  providers: [
    AccessGuard,
    TestResolver
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
