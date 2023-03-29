import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './pages/main/main.component';

import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {ReactiveFormsModule} from '@angular/forms';
import {FarmaService} from './farma.service'
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { AllDrugsComponent } from './pages/all-drugs/all-drugs.component';
import { DrugComponent } from './components/drug/drug.component';
import { DrugInfoComponent } from './pages/drug-info/drug-info.component';
import { ProfileComponent } from './components/profile/profile.component';
import { ImportsComponent } from './pages/imports/imports.component'; 
import { MatTableModule } from '@angular/material';
import { PharmacyComponent } from './components/pharmacy/pharmacy.component';
import { PharmaciesComponent } from './pages/pharmacies/pharmacies.component';
import { PharmacyInfoComponent } from './pages/pharmacy-info/pharmacy-info.component' 
import { AuthorizationComponent } from './pages/authorization/authorization.component';
import { WorkerInfoComponent } from './pages/worker-info/worker-info.component';
import { ImportComponent } from './components/import/import.component';
import { SalesComponent } from './pages/sales/sales.component';
import { SaleComponent } from './components/sale/sale.component';
import { SuppliersComponent } from './pages/suppliers/suppliers.component';
import { SupplierComponent } from './components/supplier/supplier.component';
import { WritedownsComponent } from './pages/writedowns/writedowns.component';
import { WritedownComponent } from './components/writedown/writedown.component';
import { WorkingHoursComponent } from './pages/working-hours/working-hours.component';
import { WorkingHourComponent } from './components/working-hour/working-hour.component';

// import { RegistrationComponent } from './pages/registration/registration.component';
// import { InputComponent } from './pages/input/input.component';
// import { HeaderComponent } from './components/header/header.component';
// import { FooterComponent } from './components/footer/footer.component';
// import { LoginFormComponent } from './components/login-form/login-form.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    // RegistrationComponent,
    // InputComponent,
    HeaderComponent,
    FooterComponent,
    AllDrugsComponent,
    DrugComponent,
    DrugInfoComponent,
    ProfileComponent,
    ImportsComponent,
    PharmacyComponent,
    PharmaciesComponent,
    PharmacyInfoComponent,
    AuthorizationComponent,
    WorkerInfoComponent,
    ImportComponent,
    SalesComponent,
    SaleComponent,
    SuppliersComponent,
    SupplierComponent,
    WritedownsComponent,
    WritedownComponent,
    WorkingHoursComponent,
    WorkingHourComponent,
    // LoginFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    // MatButtonModule,
    // MatDialogModule,
    NoopAnimationsModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    MatTableModule,
    // MatChipsModule,
    // MatInputModule,
    // MatListModule,
    ReactiveFormsModule,
  ],
  providers: [FarmaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
