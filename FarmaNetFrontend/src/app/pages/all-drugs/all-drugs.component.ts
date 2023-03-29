import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
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
  id!: string | null;
  pharmacyId: string | null = localStorage.getItem('pharmacyId');

  constructor(private drugService: DrugService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id');
    });
    this.loadProducts();
  }

  loadProducts() {
    if(this.id == null)
    {
    this.drugService.getDrugs()
      .subscribe((data: any) => this.drugs = data);
    }
    else {
      this.drugService.getDrugsByPharmacyId(this.pharmacyId)
      .subscribe((data: any) => this.drugs = data);
    }
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
