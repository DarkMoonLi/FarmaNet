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
    // MatChipsModule,
    // MatInputModule,
    // MatListModule,
    ReactiveFormsModule,
  ],
  providers: [FarmaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
