import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoreModule } from './core/core.module';

import { AccessGuard } from './guards/access.guard';
import { TestResolver } from './test.resolver';

@NgModule({
  declarations: [
    AppComponent,
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
