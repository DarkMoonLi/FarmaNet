import { Component, Input, OnInit } from '@angular/core';
import { SaleDto } from 'src/app/dto/sale.dto';

@Component({
  selector: 'app-sale',
  templateUrl: './sale.component.html',
  styleUrls: ['./sale.component.scss']
})
export class SaleComponent implements OnInit {

  @Input() 
  sale!: SaleDto;


  constructor() { }

  ngOnInit(): void {
  }

}
