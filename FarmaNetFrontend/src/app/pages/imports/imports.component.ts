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


import { Component, OnInit } from '@angular/core';
import { ImportDto } from 'src/app/dto/import.dto';

const ELEMENT_DATA: ImportDto[] = [
  {ImportId: 0, Number: 1, Date: '01.01.2023', SumPrice: 12000, SupplierId: 4, PharmacyId: 1 },
  {ImportId: 34, Number: 2, Date: '01.01.2023', SumPrice: 12000, SupplierId: 5, PharmacyId: 2 },
  {ImportId: 90, Number: 3, Date: '01.01.2023', SumPrice: 12000, SupplierId: 6, PharmacyId: 1 }
];

/**
 * @title Basic use of `<table mat-table>`
 */
@Component({
  selector: 'app-imports',
  styleUrls: ['./imports.component.scss'],
  templateUrl: './imports.component.html',
})
export class ImportsComponent implements OnInit {
  public displayedColumns: string[] = ['ImportId', 'Number', 'Date', 'SumPrice', 'SupplierId', 'PharmacyId'];
  public dataSource = ELEMENT_DATA;
  
  constructor() { }

  ngOnInit(): void {
  }
}

// @Component({
//   selector: 'app-imports',
//   templateUrl: './imports.component.html',
//   styleUrls: ['./imports.component.scss']
// })