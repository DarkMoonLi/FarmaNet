import { Component, OnInit } from '@angular/core';
import { DrugDto } from 'src/app/dto/drug.dto';
import { Router } from '@angular/router';


@Component({
  selector: 'app-drug-info',
  templateUrl: './drug-info.component.html',
  styleUrls: ['./drug-info.component.scss']
})
export class DrugInfoComponent implements OnInit {

  panelOpenState = false;

  constructor(private router: Router) { 
  }

  ngOnInit(): void {
  }
  
  //Запрашивать при открытии страницы эти рецепты

  Data: DrugDto = {
    name: 'Ибупрофен',
    description: 'Описание...',
  };
  data = Array(1).fill(this.Data);
}