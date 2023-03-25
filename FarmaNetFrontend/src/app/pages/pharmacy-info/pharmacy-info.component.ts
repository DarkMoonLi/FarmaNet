import { Component, OnInit } from '@angular/core';
import { DrugDto } from 'src/app/dto/drug.dto';

@Component({
  selector: 'app-pharmacy-info',
  templateUrl: './pharmacy-info.component.html',
  styleUrls: ['./pharmacy-info.component.scss']
})
export class PharmacyInfoComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  datas: DrugDto = {
    name: 'Ибупрофен',
    description: 'Описание...',
  };
  data = Array(6).fill(this.datas);
}
