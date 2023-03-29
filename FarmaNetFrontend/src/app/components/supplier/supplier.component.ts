import { Component, Input, OnInit } from '@angular/core';
import { SupplierDto } from 'src/app/dto/supplier.dto';

@Component({
  selector: 'app-supplier',
  templateUrl: './supplier.component.html',
  styleUrls: ['./supplier.component.scss']
})
export class SupplierComponent implements OnInit {
  @Input() 
  supplier!: SupplierDto;

  constructor() { }

  ngOnInit(): void {
  }

}
