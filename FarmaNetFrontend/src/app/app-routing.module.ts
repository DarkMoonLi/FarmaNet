import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './pages/main/main.component';
import { AllDrugsComponent } from './pages/all-drugs/all-drugs.component';
import { DrugInfoComponent } from './pages/drug-info/drug-info.component';
import { ProfileComponent } from './components/profile/profile.component';
import { ImportsComponent } from './pages/imports/imports.component';
import { AuthorizationComponent } from './pages/authorization/authorization.component';
import { PharmaciesComponent } from './pages/pharmacies/pharmacies.component';
import { PharmacyInfoComponent } from './pages/pharmacy-info/pharmacy-info.component';
import { WorkerInfoComponent } from './pages/worker-info/worker-info.component';

const routes: Routes = [
    {path: '', component: MainComponent},
    {path: 'drugs', component: AllDrugsComponent},
    {path: 'drug/:id', component: DrugInfoComponent},
    {path: 'profile', component: ProfileComponent},
    {path: 'imports', component: ImportsComponent},
    {path: 'authorization', component: AuthorizationComponent},
    {path: 'pharmacies', component: PharmaciesComponent},
    {path: 'pharmacy/:id', component: PharmacyInfoComponent},
    {path: 'worker', component: WorkerInfoComponent},
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
