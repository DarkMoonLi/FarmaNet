import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
openWorkingHours() {
throw new Error('Method not implemented.');
}
openWriteDowns() {
throw new Error('Method not implemented.');
}
openSuppliers() {
throw new Error('Method not implemented.');
}
openSales() {
throw new Error('Method not implemented.');
}
openProfile() {
throw new Error('Method not implemented.');
}

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

}
