import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';
import { ContentComponent } from './Components/content/content.component';
import { CalculatorComponent } from './Components/calculator/calculator.component';
import { FormsModule } from '@angular/Forms';
import { EmployeeComponent } from './Models/employee/employee.component';
import { EmpDetailsComponent } from './Components/emp-details/emp-details.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { ActorComponent } from './MovieComp/actor/actor.component';
import { DirectorComponent } from './MovieComp/director/director.component';
import { MoviesComponent } from './MovieComp/movies/movies.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    ContentComponent,
    CalculatorComponent,
    EmployeeComponent,
    EmpDetailsComponent,
    AddEmpComponent,
    ActorComponent,
    DirectorComponent,
    MoviesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
