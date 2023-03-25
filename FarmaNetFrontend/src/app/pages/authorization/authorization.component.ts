import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-authorization',
  templateUrl: './authorization.component.html',
  styleUrls: ['./authorization.component.scss']
})
export class AuthorizationComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  openMain() {
    this.router.navigate(['/']);
  }

}
