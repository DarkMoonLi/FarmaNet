import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './pages/main/main.component';

import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {MatChipsModule} from '@angular/material/chips';
import {MatInputModule} from '@angular/material/input';
import {MatListModule} from '@angular/material/list';
import {ReactiveFormsModule} from '@angular/forms';
import {FarmaService} from './farma.service'
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { AllDrugsComponent } from './pages/all-drugs/all-drugs.component';
import { DrugComponent } from './components/drug/drug.component';
import { DrugInfoComponent } from './components/drug-info/drug-info.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { ImportsComponent } from './pages/imports/imports.component';
// import { MatTableModule } from '@angular/material/table'  
import { MatTableModule } from '@angular/material' 

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
