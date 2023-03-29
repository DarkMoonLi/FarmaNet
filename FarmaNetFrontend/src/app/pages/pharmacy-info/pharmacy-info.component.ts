import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DrugDto } from 'src/app/dto/drug.dto';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';
import { DrugService } from 'src/app/services/drug.service';
import { PharmacyInfoService } from 'src/app/services/pharmacy-info.service';

@Component({
  selector: 'app-pharmacy-info',
  templateUrl: './pharmacy-info.component.html',
  styleUrls: ['./pharmacy-info.component.scss']
})
export class PharmacyInfoComponent implements OnInit {

  constructor(private router: Router, private pharmacyInfoService: PharmacyInfoService, private route: ActivatedRoute, private drugService: DrugService) { 
  }

  id: string | null = sessionStorage.getItem('pharmacyId');

  ngOnInit(): void {
    this.loadProduct();
  }

  pharmacy: PharmacyDto = new PharmacyDto();
  drugs!: DrugDto[];

  loadProduct() {
    this.pharmacyInfoService.getPharmacy(this.id)
      .subscribe((data: any) => this.pharmacy = data);

      this.drugService.getDrugsByPharmacyId(this.id)
      .subscribe((data: any) => this.drugs = data);
  }
}
