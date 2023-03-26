import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';

@Component({
  selector: 'app-pharmacy',
  templateUrl: './pharmacy.component.html',
  styleUrls: ['./pharmacy.component.scss']
})
export class PharmacyComponent implements OnInit {

  @Input() Pharmacy!: PharmacyDto;

  constructor(private router: Router) {  }

  ngOnInit(): void {
  }

  goToPharmacyId(pharmacyId: number| undefined)
  {
    this.router.navigate(['/pharmacy/:id', {id: pharmacyId}])
  }

}
