import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { SMService } from './services/sm.service';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    SMService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
