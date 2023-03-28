import { Component, OnInit } from '@angular/core';
import { DrugDto } from 'src/app/dto/drug.dto';
import { DrugService } from 'src/app/services/drug.service';

@Component({
  selector: 'app-all-drugs',
  templateUrl: './all-drugs.component.html',
  styleUrls: ['./all-drugs.component.scss']
})
export class AllDrugsComponent implements OnInit {

  public title!: string;
  drug: DrugDto = new DrugDto();
  drugs!: DrugDto[];

  constructor(private drugService: DrugService ) {}

  ngOnInit(): void {
    this.loadProducts();
  }

  loadProducts() {
    this.drugService.getDrugs()
      .subscribe((data: any) => this.drugs = data);
  }

  Tags: Tag[] = [
    { name: 'Лекарства и Бады'},
    { name: 'Активная косметика'},
    { name: 'Красота и Здоровье'},
    { name: 'Ортопедия'},
  ]
};

export interface Tag {
  name: string;
}
