import {Component, OnInit} from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ImportsService } from 'src/app/services/imports.service';
import { ImportDto } from '../../dto/import.dto';

@Component({
  selector: 'app-imports',
  styleUrls: ['./imports.component.scss'],
  templateUrl: './imports.component.html',
})
export class ImportsComponent implements OnInit {
  import!: ImportDto;
  imports!: ImportDto[];                 // массив товаров
  tableMode: boolean = true;           // табличный режим

  constructor(private router: Router, private importService: ImportsService, private route: ActivatedRoute) { }

  id!: string | null;

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id');
    });
      this.loadProducts(); 
  }
  // получаем данные через сервис
  loadProducts() {
      this.importService.getImports(this.id)
        .subscribe((data: any) => this.imports = data);
  }

}