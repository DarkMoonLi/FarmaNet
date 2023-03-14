import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { DrugTypeDto } from '../../dto/medication-type.dto';
 
@Injectable()
export class DataService {
 
    private url = "https://localhost:44362/medicationType/";
 
    constructor(private http: HttpClient) {
    }
 
    getMedicationTypes() {
        return this.http.get(this.url + 'all');
    }
     
    getProduct(id: number) {
        return this.http.get(this.url + id);
    }
     
    createProduct(drugType: DrugTypeDto) {
        return this.http.post(this.url + 'add', drugType);
    }
    updateProduct(drugType: DrugTypeDto) {
  
        return this.http.put(this.url, drugType);
    }
    deleteProduct(id: number) {
        return this.http.delete(this.url + 'delete/' + id);
    }
}