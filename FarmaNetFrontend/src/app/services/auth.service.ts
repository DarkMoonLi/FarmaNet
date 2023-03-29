import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private url = "https://localhost:44362/";

  constructor(private http: HttpClient,private router: Router) { }

  login(login: string, password: string) {
    let response = this.http.post(this.url + 'authorization', {login: login, password: password})
    response.subscribe((resp: any) => {
      if (resp != null) {
        sessionStorage.setItem('token', resp.value.token);
        sessionStorage.setItem('workerId', resp.value.workerInformationId);
        sessionStorage.setItem('pharmacyId', resp.value.pharmacyId);
        sessionStorage.setItem('accountId', resp.value.accountId);
        this.router.navigate(['worker/', resp.value.workerInformationId ]);
      }
    })
  }

  tokenName: string = 'token'

  getToken(): string | null {
    return this.tokenName;
  }

  isLoggedIn(): boolean {
    return !!this.tokenName;
  }
}