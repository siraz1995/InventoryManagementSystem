import { DatePipe } from '@angular/common';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { CityService } from '../shared/city.service';
import { City } from '../shared/all-models.model';
import { CityFormComponent } from './city-form/city-form.component';



@Component({
  selector: 'app-city-details',
  templateUrl: './city-details.component.html',
  styleUrls: ['./city-details.component.css']
})
export class CityDetailsComponent implements OnInit {

  constructor(public citiService: CityService, public datepipe: DatePipe, public toast: ToastrService) { }
  @ViewChild(CityFormComponent) citi: CityFormComponent;



  ngOnInit() {
    this.citiService.getCitys().subscribe(data => {
      this.citiService.listCity = data;
    });
  }


  populateCity(selecetedCity: City) {
    this.citiService.cityData = selecetedCity;
  }

  //populateCity(selecetedCity: City) {
  //  this.citiService.cityData = selecetedCity;
  //}


  delete(id: number) {
    if (confirm('Are you really want to delete this record?')) {
      this.citiService.deleteCity(id).subscribe(data => {
        this.citiService.getCitys().subscribe(data => {
          this.citiService.listCity = data;
          this.toast.error('Sucess', 'Record Deleted');
        });
      },
        err => {
        });
    }
  }

}
