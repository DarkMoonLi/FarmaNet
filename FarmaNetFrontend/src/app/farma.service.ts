import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FarmaService {
  public _http: HttpClient;

  constructor(public http: HttpClient) { 
    this._http = http;
  }
}
