import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { WritedownDto } from 'src/app/dto/writedown.dto';
import { WritedownService } from 'src/app/services/writedown.service';

@Component({
  selector: 'app-writedowns',
  templateUrl: './writedowns.component.html',
  styleUrls: ['./writedowns.component.scss']
})
export class WritedownsComponent implements OnInit {

  public writedown!: WritedownDto;
  public writedowns!: WritedownDto[];                 // массив товаров
  public pharmacyId: string | null = sessionStorage.getItem('pharmacyId');

  constructor(private router: Router, private writedownService: WritedownService) { }

  ngOnInit(): void {
    this.loadProducts()
  }

  loadProducts() {
    this.writedownService.getWriteDowns(this.pharmacyId)
      .subscribe((data: any) => this.writedowns = data);
  }

}
