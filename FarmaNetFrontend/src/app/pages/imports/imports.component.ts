// import { Component, OnInit } from '@angular/core';
// import { NgModule } from '@angular/core';
// import { ImportDto } from 'src/app/dto/import.dto';

// @Component({
//   selector: 'app-imports',
//   templateUrl: './imports.component.html',
//   styleUrls: ['./imports.component.scss']
// })

// export class ImportsComponent implements OnInit {
//   data: ImportDto[] = [
//     {ImportId: 0, Number: 1, Date: '01.01.2023', SumPrice: 12000, SupplierId: 4, PharmacyId: 1 },
//     {ImportId: 0, Number: 2, Date: '01.01.2023', SumPrice: 12000, SupplierId: 5, PharmacyId: 2 },
//     {ImportId: 0, Number: 3, Date: '01.01.2023', SumPrice: 12000, SupplierId: 6, PharmacyId: 1 }
//   ]
//   public dataSource: ImportDto[] = this.data;

//   displayedColumns: string[] = ['ImportId', 'Number', 'Date', 'SumPrice', 'SupplierId', 'PharmacyId'];

//   constructor() { }

//   ngOnInit(): void {
//   }
// }

// // @NgModule({
// //   imports: [MatTableModule]
// // })
// // export class AppModule { }

// // export class TableColumnStylingExample {
// //   displayedColumns: string[] = ['ImportId', 'Number', 'Date', 'SumPrice', 'SupplierId', 'PharmacyId'];
// //   dataSource = this.dataSource;
// // }

// // const data: ImportDto[] = [
// //   {ImportId: 0, Number: 1, Date: '01.01.2023', SumPrice: 12000, SupplierId: 4, PharmacyId: 1 },
// //   {ImportId: 0, Number: 2, Date: '01.01.2023', SumPrice: 12000, SupplierId: 5, PharmacyId: 2 },
// //   {ImportId: 0, Number: 3, Date: '01.01.2023', SumPrice: 12000, SupplierId: 6, PharmacyId: 1 }
// // ]


// import { Component, OnInit } from '@angular/core';
// import { ImportDto } from 'src/app/dto/import.dto';

// const ELEMENT_DATA: ImportDto[] = [
//   {ImportId: 0, Number: 1, Date: '01.01.2023', SumPrice: 12000, SupplierId: 4, PharmacyId: 1 },
//   {ImportId: 34, Number: 2, Date: '01.01.2023', SumPrice: 12000, SupplierId: 5, PharmacyId: 2 },
//   {ImportId: 90, Number: 3, Date: '01.01.2023', SumPrice: 12000, SupplierId: 6, PharmacyId: 1 }
// ];

// /**
//  * @title Basic use of `<table mat-table>`
//  */
// @Component({
//   selector: 'app-imports',
//   styleUrls: ['./imports.component.scss'],
//   templateUrl: './imports.component.html',
// })
// export class ImportsComponent implements OnInit {
//   public displayedColumns: string[] = ['ImportId', 'Number', 'Date', 'SumPrice', 'SupplierId', 'PharmacyId'];
//   public dataSource = ELEMENT_DATA;
  
//   constructor() { }

//   ngOnInit(): void {
//   }
// }

// @Component({
//   selector: 'app-imports',
//   templateUrl: './imports.component.html',
//   styleUrls: ['./imports.component.scss']
// })


import {Component} from '@angular/core';

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne'},
];

/**
 * @title Basic use of `<table mat-table>`
 */
// selector: 'app-imports',
//   styleUrls: ['./imports.component.scss'],
//   templateUrl: './imports.component.html',

@Component({
  selector: 'app-imports',
  styleUrls: ['./imports.component.scss'],
  templateUrl: './imports.component.html',
})
export class ImportsComponent {
  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  dataSource = ELEMENT_DATA;
}