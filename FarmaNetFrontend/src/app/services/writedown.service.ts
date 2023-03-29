import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class WritedownService {
  private url = "https://localhost:44362/";

  constructor(private http: HttpClient) {
  }
 
  getWriteDowns(id: string | null) {
      return this.http.get(this.url + 'writeDownsByPharmacy/' + id);
  }
}
