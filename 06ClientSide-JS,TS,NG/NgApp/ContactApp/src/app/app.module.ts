import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { TestComponent } from './test.component';
import { ContactComponent } from './contact/contact.component';

@NgModule({
  declarations: [
    AppComponent,
    TestComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  // you can inject your service as a single instance
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
