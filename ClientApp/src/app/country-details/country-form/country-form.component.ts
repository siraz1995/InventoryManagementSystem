
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CountryService } from 'src/app/shared/country.service';
import { Country } from 'src/app/shared/all-models.model';

@Component({
  selector: 'app-country-form',
  templateUrl: './country-form.component.html',
  styleUrls: ['./country-form.component.css']
})
export class CountryFormComponent implements OnInit {

  constructor(public CounService: CountryService, public toast: ToastrService) { }
  @ViewChild('checkbox1') checkBox: ElementRef;
  isSlide: string = 'off';

  ngOnInit() {
    this.CounService.getCountry().subscribe(data => {
      this.CounService.listCountry = data;
    });
  }

  submit(form: NgForm) {
    if (this.CounService.countryData.id == 0)
      this.insertCountry(form);
    else
      this.updateCuntry(form);
  }

  insertCountry(myform: NgForm) {
    this.CounService.saveCountry().subscribe(d => {
      this.resetForm(myform);
      this.refereshData();
      this.toast.success('Success', 'Record Saved');
    });
  }
  updateCuntry(myform: NgForm) {
    this.CounService.updateCountry().subscribe(d => {
      this.resetForm(myform);
      this.refereshData();
      this.toast.warning('Success', 'Record Updated');
    });
  }
  resetForm(myform: NgForm) {
    myform.form.reset(myform.value);
    this.CounService.countryData = new Country();
    this.hideShowSlide();
  }
  refereshData() {
    this.CounService.getCountry().subscribe(res => {
      this.CounService.listCountry = res;
    });
  }

  hideShowSlide() {
    if (this.checkBox.nativeElement.checked) {
      this.checkBox.nativeElement.checked = false;
      this.isSlide = 'off';
    }
    else {
      this.checkBox.nativeElement.checked = true;
      this.isSlide = 'on';
    }
  }
}
