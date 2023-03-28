import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DrugDto } from '../dto/drug.dto';


@Injectable({
  providedIn: 'root'
})
export class DrugService {
  private url = "https://localhost:44362/";
 
  constructor(private http: HttpClient) {
  }
 
  getDrugs() {
      return this.http.get(this.url + 'drugs');
  }

  getDrugsByPharmacyId(id: string | null) {
    return this.http.get(this.url + 'drugs/' + id);
}
}
