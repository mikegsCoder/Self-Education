import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CoreModule } from './core/core.module';
import { SharedModule } from './shared/shared.module';
import { HomeComponent } from './home/home.component';

import { AccessGuard } from './guards/access.guard';
import { TestResolver } from './test.resolver';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    CoreModule,
    SharedModule
  ],
  providers: [ 
    TestResolver,
    AccessGuard
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
