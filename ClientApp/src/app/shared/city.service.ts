import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Country, City } from './all-models.model';

@Injectable({
  providedIn: 'root'
})
export class CityService {


  constructor(private myhttp: HttpClient) { }

  countryUrl: string = 'http://localhost:17281/api/Country';
  cityUrl: string = 'http://localhost:17281/api/City';

  listCity: City[] = [];
  listCountry: Country[] = [];
  cityData: Country = new Country();

  saveCity() {
    return this.myhttp.post(this.cityUrl, this.cityData);
  }
  updateCity() {
    return this.myhttp.put(`${this.cityUrl}/${this.cityData.countryId}`, this.cityData);
  }
  getCountrys(): Observable<Country[]> {
    return this.myhttp.get<Country[]>(this.countryUrl);
  }
  getCitys(): Observable<City[]> {
    return this.myhttp.get<City[]>(this.cityUrl);
  }
  deleteCity(cityId: number) {
    return this.myhttp.delete(`${this.cityUrl}/${cityId}`);
  }
}
