import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Country } from './all-models.model';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  constructor(private myhttp: HttpClient) { }
  countryUrl: string = 'http://localhost:17281/api/Country';

  listCountry: Country[] = []; 
  countryData: Country = new Country();


  saveCountry() {
    return this.myhttp.post(this.countryUrl, this.countryData);
  }
  updateCountry() {
    return this.myhttp.put(`${this.countryUrl}/${this.countryData.id}`, this.countryData);
  }
  getCountry(): Observable<Country[]> {
    return this.myhttp.get<Country[]>(this.countryUrl);
  }

  deleteCountry(id: number) {
    return this.myhttp.delete(`${this.countryUrl}/${id}`);
  }
}
