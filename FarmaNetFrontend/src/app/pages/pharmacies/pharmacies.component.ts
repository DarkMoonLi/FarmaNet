import { Component, OnInit } from '@angular/core';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';

@Component({
  selector: 'app-pharmacies',
  templateUrl: './pharmacies.component.html',
  styleUrls: ['./pharmacies.component.scss']
})
export class PharmaciesComponent implements OnInit {

  public title!: string;

  constructor() { }

  ngOnInit(): void {
  }

  datas: PharmacyDto = {
    name: 'Аптека №1',
    address: 'Йошкар-Ола, ул. Лобачевского, дом 16',
    image: '/',
    email: 'aptekaFirst@mail.ru',
    description: 'Cool pharmacy'
  };
  data = Array(10).fill(this.datas);

}
