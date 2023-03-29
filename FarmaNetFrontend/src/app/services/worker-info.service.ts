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

  sendImage(formData: any) {
    return this.http.post(this.url + 'workerInfromationImages/upload', formData);
  }

  getImage(id: string | null) {
    return this.http.get(this.url + 'workerPharmacy/' + id);
  }

  updateData(formData: any) {
    return this.http.post(this.url + 'workerInformations/update', formData);
  }
}
