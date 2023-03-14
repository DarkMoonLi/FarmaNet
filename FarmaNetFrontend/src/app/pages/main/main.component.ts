import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from './data.service';
import { DrugTypeDto } from 'src/app/dto/medication-type.dto';
import { DrugComponent } from 'src/app/components/drug/drug.component';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss'],
  providers: [DataService]
})
export class MainComponent {

  // public data!: RecipeDto[];
  public title!: string;
  // Categories: Category[] = [
  //   { name: 'Аптечка', photo: 'Rectangle-18.svg'},
  //   { name: 'Простуда', photo: 'Rectangle-18.svg' },
  //   { name: 'Головная боль', photo: 'Rectangle-18.svg' },
  //   { name: 'Насморк', photo: 'Rectangle-18.svg' },
  //   { name: 'Кашель', photo: 'Rectangle-18.svg' },
  //   { name: 'Бады', photo: 'Rectangle-18.svg' },
  //   { name: 'Витамины', photo: 'Rectangle-18.svg' },
  //   { name: 'Памперсы', photo: 'Rectangle-18.svg' }
  // ];
  Tags: Tag[] = [
    { name: 'Лекарства и Бады'},
    { name: 'Активная косметика'},
    { name: 'Красота и Здоровье'},
    { name: 'Ортопедия'},
  ]

  drugType: DrugTypeDto = new DrugTypeDto();   // изменяемый товар
  drugTypes!: DrugTypeDto[];                // массив товаров
  tableMode: boolean = true;          // табличный режим

  constructor(private router: Router, private dataService: DataService) {}

  ngOnInit(): void {
    this.loadProducts();
  }

  loadProducts() {
    this.dataService.getMedicationTypes()
      .subscribe((data: any) => this.drugTypes = data);
  }

  // сохранение данных
  save() {
    if (this.drugType.id == null) {
        this.dataService.createProduct(this.drugType);
    } else {
        this.dataService.updateProduct(this.drugType)
            .subscribe(data => this.loadProducts());
    }
    this.cancel();
}
editProduct(p: DrugTypeDto) {
    this.drugType = p;
}
cancel() {
    this.drugType = new DrugTypeDto();
    this.tableMode = true;
}
delete(p: DrugTypeDto) {
  if (p.id){
    this.dataService.deleteProduct(p.id)
        .subscribe(data => this.loadProducts());
  }
}
add() {
    this.cancel();
    this.tableMode = false;
}

  openDialog() {
    // this.dialog.open(DialogOptionsComponent);
  } 

  openNewRecipe(){
    this.router.navigate(['/new_farma']);
  }

  // async onProcess(){
  //   await this.httpService.searchRecipe(this.title).then((data: RecipeDto[]) => {
  //     this.data = data;
  //   });;
  // }

  // constructor() { }

  // ngOnInit(): void {
  // }

}
export interface Category {
  name: string;
  // text: string;
  photo: string;
}
export interface Tag {
  name: string;
}
