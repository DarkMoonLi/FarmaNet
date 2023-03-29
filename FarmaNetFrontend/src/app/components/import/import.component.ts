import { Component, Input, OnInit } from '@angular/core';
import { ImportDto } from 'src/app/dto/import.dto';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';
import { SupplierDto } from 'src/app/dto/supplier.dto';

@Component({
  selector: 'app-import',
  templateUrl: './import.component.html',
  styleUrls: ['./import.component.scss']
})
export class ImportComponent implements OnInit {

  @Input() 
  import!: ImportDto;

  constructor() { }

  ngOnInit(): void {
  }

}
