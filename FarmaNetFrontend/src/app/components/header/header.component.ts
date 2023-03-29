import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(private router: Router, private route: ActivatedRoute, private authService: AuthService) { }

  workerId: string | null = sessionStorage.getItem('workerId');
  pharmacyId: string | null = sessionStorage.getItem('pharmacyId');
  accountId: string | null = sessionStorage.getItem('accountId');

  ngOnInit(): void {
  }

  openMain() {
    this.router.navigate(['/']);
  }

  isLoggedIn() {
    return this.authService.isLoggedIn();
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
      this.router.navigate(['/writedowns']);
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
    checkToken() {
      return localStorage.getItem('token') !== null
    }

}
