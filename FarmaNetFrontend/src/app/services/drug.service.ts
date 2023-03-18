import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DrugDto } from '../dto/drug.dto';


@Injectable({
  providedIn: 'root'
})
export class DrugService {
  public _http: HttpClient;

  constructor(public http: HttpClient) { 
    this._http = http;
  }
  async getData(): Promise<any> {
    return this._http.get<DrugDto[]>('/medications').toPromise();
  }
  // async saveProfile(): Promise<any> {
  //   return this._http.get
  // }



  // constructor() { }
}
