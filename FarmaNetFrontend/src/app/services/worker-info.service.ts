import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class WorkerInfoService {
  private url = "https://localhost:44362/";
 
  constructor(private http: HttpClient) {
  }
 
  getWorker(id: string | null) {
      return this.http.get(this.url + 'workerInformation/' + id);
  }

  getPharmacy(id: string | null) {
    return this.http.get(this.url + 'workerPharmacy/' + id);
  }

  getPosition(id: string | null) {
    return this.http.get(this.url + 'workerPosition/' + id);
  }
}
