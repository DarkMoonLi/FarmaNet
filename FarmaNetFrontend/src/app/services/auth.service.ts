import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  url = "https://localhost:44362/";
  
  constructor(private http: HttpClient,private router: Router) { }

  login(login: string, password: string) {
    let response = this.http.post(this.url + 'authorization', {login: login, password: password})
    response.subscribe((resp: any) => {
      if (resp != null) {
        this.router.navigate(['worker/', resp.value.workerInformationId ]);
        localStorage.setItem('token', resp.value.token);
        localStorage.setItem('workerId', resp.value.workerId);
        localStorage.setItem('pharmacyId', resp.value.pharmacyId);
      }
    })
  }

  logout() {
    localStorage.removeItem('token');
  }

  public get logIn(): boolean {
    return (localStorage.getItem('token') !== null);
  }
}