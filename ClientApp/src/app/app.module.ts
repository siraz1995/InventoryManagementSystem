import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { DatePipe } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { CountryDetailsComponent } from './country-details/country-details.component';
import { CountryFormComponent } from './country-details/country-form/country-form.component';
import { CityDetailsComponent } from './city-details/city-details.component';
import { CityFormComponent } from './city-details/city-form/city-form.component';



@NgModule({
  declarations: [
    AppComponent,
    CountryDetailsComponent,
    CountryFormComponent,
    CityDetailsComponent,
    CityFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
