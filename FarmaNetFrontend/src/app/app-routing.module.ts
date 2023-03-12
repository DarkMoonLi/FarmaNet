import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './pages/main/main.component';
import { AllDrugsComponent } from './pages/all-drugs/all-drugs.component';
import { DrugInfoComponent } from './components/drug-info/drug-info.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { ImportsComponent } from './pages/imports/imports.component';

const routes: Routes = [
  {path: '', component: MainComponent},
    {path: 'main', component: AllDrugsComponent},
    {path: 'drug/:id', component: DrugInfoComponent},
    {path: 'profile', component: ProfileComponent},
    {path: 'imports', component: ImportsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
