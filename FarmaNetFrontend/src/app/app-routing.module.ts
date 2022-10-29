import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: '', component: MainPageComponent},
    {path: 'main', component: MainPageComponent},
    {path: 'recipes', component: RecipesPageComponent},
    {path: 'new_recipe', component: CreateRecipePageComponent},
    {path: 'recipes/new_recipe', component: CreateRecipePageComponent},
    {path: 'login', component: DialogElementComponent},
    {path: 'favorites', component: FavoritesPageComponent},
    {path: 'change_recipe/:id', component: CreateRecipePageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
