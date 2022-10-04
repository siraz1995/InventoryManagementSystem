import { DatePipe } from '@angular/common';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { CountryService } from '../shared/country.service';
import { Country } from '../shared/all-models.model';
import { CountryFormComponent } from './country-form/country-form.component';


@Component({
  selector: 'app-country-details',
  templateUrl: './country-details.component.html',
  styleUrls: ['./country-details.component.css']
})
export class CountryDetailsComponent implements OnInit {

  constructor(public CounService: CountryService, public datepipe: DatePipe, public toast: ToastrService) { }
  @ViewChild(CountryFormComponent) Coun: CountryFormComponent;
  ngOnInit() {
    this.CounService.getCountry().subscribe(data => {
      this.CounService.listCountry = data;
    });
  }
  populateCountry(selecetedCountry: Country) {
    this.CounService.countryData = selecetedCountry;
  }
  delete(id: number) {
    if (confirm('Are you really want to delete this record?')) {
      this.CounService.deleteCountry(id).subscribe(data => {
        this.CounService.getCountry().subscribe(data => {
          this.CounService.listCountry = data;
          this.toast.error('Success', 'Record Deleted');
        });
      },
        err => {
        });
    }
  }
}
