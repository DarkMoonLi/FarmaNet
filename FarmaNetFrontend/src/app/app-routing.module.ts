import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './pages/main/main.component';
import { AllDrugsComponent } from './pages/all-drugs/all-drugs.component';
import { DrugInfoComponent } from './components/drug-info/drug-info.component';

const routes: Routes = [
  {path: '', component: MainComponent},
    {path: 'main', component: AllDrugsComponent},
    {path: 'drug/:id', component: DrugInfoComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
