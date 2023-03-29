import {Component, OnInit} from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { ImportsService } from 'src/app/services/imports.service';
import { ImportDto } from '../../dto/import.dto';

@Component({
  selector: 'app-imports',
  styleUrls: ['./imports.component.scss'],
  templateUrl: './imports.component.html',
})
export class ImportsComponent implements OnInit {
  public import: ImportDto = new ImportDto();
  public imports!: ImportDto[];                 // массив товаров

  constructor(private router: Router, private importService: ImportsService) { }

  id: string | null = sessionStorage.getItem('pharmacyId');

  ngOnInit() {
      this.loadProducts(); 
  }
  // получаем данные через сервис
  loadProducts() {
      this.importService.getImports(this.id)
        .subscribe((data: any) => {this.imports = data; console.log(this.imports);});
  }

}