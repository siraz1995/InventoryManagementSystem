export class Customer {
  customerId: number = 0;
  customerName: string = '';
  phone: string = '';
  email: string = '';
  postCode: string = '';
  address: string = '';
  taxNumber: string = '';
  cityID: number = 0;
  city: string = '';
}
export class City {
  cityId: number = 0;
  cityName: string = '';
  countryId: number = 0;
  countryName: string = '';
}
export class Country {
  id: number = 0;
  countryName: string = '';
}
