import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SaleDto } from 'src/app/dto/sale.dto';
import { AuthService } from 'src/app/services/auth.service';
import { ImportsService } from 'src/app/services/imports.service';
import { SaleServiceService } from 'src/app/services/sale-service.service';

@Component({
  selector: 'app-sales',
  templateUrl: './sales.component.html',
  styleUrls: ['./sales.component.scss']
})
export class SalesComponent implements OnInit {

  public sale: SaleDto = new SaleDto();
  public sales!: SaleDto[];                 // массив товаров
  public pharmacyId: string | null = sessionStorage.getItem('pharmacyId');

  constructor(private router: Router, private saleService: SaleServiceService) { }

  ngOnInit(): void {
    this.loadProducts()
  }

  loadProducts() {
    this.saleService.getSales(this.pharmacyId)
      .subscribe((data: any) => this.sales = data);
  }
}
