import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PharmaciesService {

  private url = "https://localhost:44362/";
 
  constructor(private http: HttpClient) {
  }
 
  getDrugs() {
      return this.http.get(this.url + 'pharmacies');
  }
}
