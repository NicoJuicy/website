/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { CoreModule } from './@core/core.module';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { ThemeModule } from './@theme/theme.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {MainPageModule} from './pages/main/main-page.module';
import {NotFoundModule} from './pages/not-found/not-found.module';
import {JwtModule} from '@auth0/angular-jwt';
import {OutgoingModule} from './pages/outgoing/outgoing.module';
import {MarkdownModule, MarkedOptions} from 'ngx-markdown';

export function tokenGetter() {
  return localStorage.getItem('accessToken');
}

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MainPageModule,
    NotFoundModule,
    OutgoingModule,
    AppRoutingModule,
    HttpClientModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: [
          'localhost:3002',
          'localhost:4200',
          '141.210.25.113',
        ],
        throwNoTokenError: true,
      },
    }),
    MarkdownModule.forRoot({
      markedOptions: {
        provide: MarkedOptions,
        useValue: {
          gfm: true,
          breaks: true,
          tables: false,
          smartLists: true,
          smartypants: false,
          baseUrl: 'https://',
        },
      },
    }),

    NgbModule,
    ThemeModule.forRoot(),
    CoreModule.forRoot(),
  ],
  bootstrap: [AppComponent],
  providers: [
    { provide: APP_BASE_HREF, useValue: '/' },
  ],
})
export class AppModule {
}
