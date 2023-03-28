import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PharmacyInfoService {
  private url = "https://localhost:44362/";
 
  constructor(private http: HttpClient) {
  }
 
  getPharmacy(id: string | null) {
      return this.http.get(this.url + 'pharmacy/' + id);
  }
}
