import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';

import { storageServiceProvider } from './storage.service';
import { AuthService } from './auth.service';
import { appInterceptorProvider } from './app.interceptor';
import { AuthGuard } from './guards/auth.guard';

@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  providers: [
    storageServiceProvider,
    AuthGuard,
    appInterceptorProvider,
    AuthService
  ],
  exports: [
    HeaderComponent,
    FooterComponent
  ],
})
export class CoreModule { }
