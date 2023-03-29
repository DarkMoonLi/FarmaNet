import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SupplierDto } from 'src/app/dto/supplier.dto';
import { SupplierService } from 'src/app/services/supplier.service';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.scss']
})
export class SuppliersComponent implements OnInit {

  public supplier!: SupplierDto;
  public suppliers!: SupplierDto[];                 // массив товаров
  public pharmacyId: string | null = sessionStorage.getItem('pharmacyId');

  constructor(private router: Router, private supplierService: SupplierService) { }

  ngOnInit(): void {
    this.loadProducts()
  }

  loadProducts() {
    this.supplierService.getSuppliers(this.pharmacyId)
      .subscribe((data: any) => {this.suppliers = data; console.log(this.suppliers);});
  }

}
