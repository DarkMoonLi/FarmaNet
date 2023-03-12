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

  openMainPage() {
    this.router.navigate(['/main']);
  }
  openRecipes() {
    this.router.navigate(['/recipes']);
  }
  openImports() {
    this.router.navigate(['/imports'])
  }
  openProfilePage() {
    this.router.navigate(['/profile']);
  }

}
