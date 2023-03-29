import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DrugInfoService {

  private url = "https://localhost:44362/";
 
  constructor(private http: HttpClient) {
  }
 
  getDrug(id: string | null) {
      return this.http.get(this.url + 'drug/' + id);
  }
}
