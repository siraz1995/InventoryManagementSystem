import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CityService } from 'src/app/shared/city.service';
import { City } from 'src/app/shared/all-models.model';

@Component({
  selector: 'app-city-form',
  templateUrl: './city-form.component.html',
  styleUrls: ['./city-form.component.css']
})
export class CityFormComponent implements OnInit {

/*  constructor(public citiService: CityService, public toast: ToastrService) { }*/
  constructor() { }

  //@ViewChild('checkbox1') checkBox: ElementRef;
  //isSlide: string = 'off';

  ngOnInit() {
    //this.citiService.getCountrys().subscribe(data => {
    //  this.citiService.listCountry = data;
    //});
  }



}
