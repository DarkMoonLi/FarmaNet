import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DrugInfoDto } from 'src/app/dto/drug-info.dto';
import { DrugInfoService } from 'src/app/services/drug-info.service';


@Component({
  selector: 'app-drug-info',
  templateUrl: './drug-info.component.html',
  styleUrls: ['./drug-info.component.scss']
})
export class DrugInfoComponent implements OnInit {

  constructor(private router: Router, private drugInfoService: DrugInfoService, private route: ActivatedRoute) { 
  }

  id!: string | null;

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id');
    });
    this.loadProduct();
  }
  
  //Запрашивать при открытии страницы эти рецепты

  drug: DrugInfoDto = new DrugInfoDto();

  loadProduct() {
    this.drugInfoService.getDrug(this.id)
      .subscribe((data: any) => this.drug = data);
  }
}