import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(private router: Router, private route: ActivatedRoute) { }

  workerId: string | null = localStorage.getItem('workerInformationId');
  pharmacyId: string | null = localStorage.getItem('pharmacyId');
  accountId: string | null = localStorage.getItem('accountId');

  ngOnInit(): void {
  }

  openMain() {
    this.router.navigate(['/']);
  }

  openMedicaments() {
    this.router.navigate(['/drugs']);
  }

  openMedicamentsPharmacy() {
    this.router.navigate(['/drugs/' + this.pharmacyId]);
  }

  openImports() {
    this.router.navigate(['/imports'])
  }
  openPharmacies() {
    this.router.navigate(['/pharmacies']);
  }

  openWorkingHours() {
    this.router.navigate(['/workingHours/']);
    }
    openWriteDowns() {
      this.router.navigate(['/writeDowns']);
    }
    openSuppliers() {
      this.router.navigate(['/suppliers']);
    }
    openSales() {
      this.router.navigate(['/sales']);
    }
    openProfile() {
      this.router.navigate(['/worker/' + this.workerId]);
    }

}
