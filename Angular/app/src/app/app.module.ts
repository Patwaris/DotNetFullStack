import { BrowserModule, } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';


import { AppComponent } from './app.component';
import {CustomerComponent} from './customer/customer.component';
import {DealerComponent} from './dealer/dealer.component';
import { AdminComponent } from './admin/admin.component';
import {TestComponent} from './test.component';



@NgModule({
  declarations: [
    AppComponent,TestComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
