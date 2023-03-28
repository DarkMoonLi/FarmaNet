import {Component, OnInit} from '@angular/core';
import { ImportDto } from '../../dto/import.dto';

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: ImportDto[] = [
  {ImportId: 0, Number: "1", Date: '01.01.2023', SumPrice: 12000, SupplierId: 4, PharmacyId: 1 },
  {ImportId: 34, Number: "2", Date: '01.01.2023', SumPrice: 12000, SupplierId: 5, PharmacyId: 2 },
  {ImportId: 90, Number: "3", Date: '01.01.2023', SumPrice: 12000, SupplierId: 6, PharmacyId: 1 }
];

@Component({
  selector: 'app-imports',
  styleUrls: ['./imports.component.scss'],
  templateUrl: './imports.component.html',
})
export class ImportsComponent implements OnInit {
  product = {} as ImportDto;
  // product: ImportDto | undefined;   // изменяемый товар
  products: ImportDto[] | undefined = ELEMENT_DATA;                // массив товаров
  tableMode: boolean = true;          // табличный режим

  constructor() { }

  ngOnInit() {
      // this.loadProducts();    // загрузка данных при старте компонента  
  }
  // получаем данные через сервис
  loadProducts() {
      // this.dataService.getProducts()
      //     .subscribe((data: Product[]) => this.products = data);
  }
  // сохранение данных
  save() {
      // if (this.product.id == null) {
      //     this.dataService.createProduct(this.product)
      //         .subscribe((data: Product) => this.products.push(data));
      // } else {
      //     this.dataService.updateProduct(this.product)
      //         .subscribe(data => this.loadProducts());
      // }
      this.cancel();
  }
  editProduct(p: ImportDto) {
      this.product = p;
  }
  cancel() {
      this.product = {} as ImportDto;
      this.tableMode = true;
  }
  delete(p: ImportDto) {
      // this.dataService.deleteProduct(p.id)
      //     .subscribe(data => this.loadProducts());
  }
  add() {
      this.cancel();
      this.tableMode = false;
  }
  // displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  // dataSource = ELEMENT_DATA;

}