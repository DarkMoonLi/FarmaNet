import { Component, OnInit } from '@angular/core';
import { DrugDto } from 'src/app/dto/drug.dto';

@Component({
  selector: 'app-all-drugs',
  templateUrl: './all-drugs.component.html',
  styleUrls: ['./all-drugs.component.scss']
})
export class AllDrugsComponent implements OnInit {

  public title!: string;

  constructor() { }

  ngOnInit(): void {
  }


  datas: DrugDto = {
    name: 'Ибупрофен',
    description: 'Описание...',
};
data = Array(6).fill(this.datas);
Tags: Tag[] = [
  { name: 'Лекарства и Бады'},
  { name: 'Активная косметика'},
  { name: 'Красота и Здоровье'},
  { name: 'Ортопедия'},
]

}

export interface Tag {
  name: string;
}
