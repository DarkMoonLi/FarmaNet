import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  openMain() {
    this.router.navigate(['/']);
  }

  openMedicaments() {
    this.router.navigate(['/drugs']);
  }

  openImports() {
    this.router.navigate(['/imports'])
  }
  openPharmacies() {
    this.router.navigate(['/pharmacies']);
  }

  openWorkingHours() {
    this.router.navigate(['/workingHours']);
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
      this.router.navigate(['/worker/:id']);
    }

}
