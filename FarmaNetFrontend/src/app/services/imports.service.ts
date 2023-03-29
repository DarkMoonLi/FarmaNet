import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ImportsService {
  private url = "https://localhost:44362/";
 
  constructor(private http: HttpClient) {
  }
 
  getImports(id: string | null) {
      return this.http.get(this.url + 'importsByPharmacy/' + id);
  }
}
