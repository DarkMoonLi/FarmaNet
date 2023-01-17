import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent {

  // public data!: RecipeDto[];
  public title!: string;
  Categories: Category[] = [
    { name: 'Аптечка', photo: 'Rectangle-18.svg'},
    { name: 'Простуда', photo: 'Rectangle-18.svg' },
    { name: 'Головная боль', photo: 'Rectangle-18.svg' },
    { name: 'Насморк', photo: 'Rectangle-18.svg' },
    { name: 'Кашель', photo: 'Rectangle-18.svg' },
    { name: 'Бады', photo: 'Rectangle-18.svg' },
    { name: 'Витамины', photo: 'Rectangle-18.svg' },
    { name: 'Памперсы', photo: 'Rectangle-18.svg' }
  ];
  Tags: Tag[] = [
    { name: 'Лекарства и Бады'},
    { name: 'Активная косметика'},
    { name: 'Красота и Здоровье'},
    { name: 'Ортопедия'},
  ]

  constructor(private router: Router) {}

  ngOnInit(): void {
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
