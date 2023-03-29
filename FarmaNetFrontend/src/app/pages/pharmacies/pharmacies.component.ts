import { Component, OnInit } from '@angular/core';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';
import { DrugService } from 'src/app/services/drug.service';
import { PharmaciesService } from 'src/app/services/pharmacies.service';

@Component({
  selector: 'app-pharmacies',
  templateUrl: './pharmacies.component.html',
  styleUrls: ['./pharmacies.component.scss']
})
export class PharmaciesComponent implements OnInit {

  public title!: string;
  public pharmacies!: PharmacyDto[];

  constructor(private pharmaciesService: PharmaciesService) { }

  ngOnInit(): void {
    this.loadProducts();
  }

  loadProducts() {
    this.pharmaciesService.getDrugs()
      .subscribe((data: any) => this.pharmacies = data);
  }

}
