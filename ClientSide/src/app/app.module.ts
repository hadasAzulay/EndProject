import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatSliderModule } from '@angular/material/slider';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainManagerComponent } from './main-manager/main-manager.component';
import { LogInComponent } from './log-in/log-in.component';
import { ProjectsComponent } from './projects/projects.component';
import { ConnectionComponent } from './connection/connection.component';
import { RouterModule } from '@angular/router';
import { AboutUsComponent } from './about-us/about-us.component';
import { PricePerOccupantComponent } from './price-per-occupant/price-per-occupant.component';
import { MarketingProjecsComponent } from './marketing-projecs/marketing-projecs.component';
import { PopulatedProjecsComponent } from './populated-projecs/populated-projecs.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { MatInputModule } from '@angular/material/input';
import { MatMenuModule } from '@angular/material/menu';
import { PersonalProjectComponent } from './personal-project/personal-project.component';
import { PersonalProgressScheduleComponent } from './personal-progress-schedule/personal-progress-schedule.component';
import { ManagementNoticesComponent } from './management-notices/management-notices.component';
import { YearCheckedComponent } from './year-checked/year-checked.component';
import { PersonalFileComponent } from './personal-file/personal-file.component';
import { PersonalProjectsComponent } from './personal-projects/personal-projects.component';
import { ProjectsInProcessComponent } from './projects-in-process/projects-in-process.component';
import { ProjProcManajComponent } from './proj-proc-manaj/proj-proc-manaj.component';
import { ContractorsComponent } from './contractors/contractors.component';
import { SuppliersComponent } from './suppliers/suppliers.component';
import { DocumentsComponent } from './documents/documents.component';
import { TrackingLogComponent } from './tracking-log/tracking-log.component';
import { CalculationTableComponent } from './calculation-table/calculation-table.component';
import { ListOfTenantsComponent } from './list-of-tenants/list-of-tenants.component';
import { ProgressScheduleComponent } from './progress-schedule/progress-schedule.component';
import { MatTableModule } from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http'
import { PeopleService } from './services/people.service';
import { MatButtonModule } from '@angular/material/button';
import { RegisterComponent } from './register/register.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';


@NgModule({
  declarations: [
    AppComponent,
    MainManagerComponent,
    LogInComponent,
    ProjectsComponent,
    ConnectionComponent,
    AboutUsComponent,
    PricePerOccupantComponent,
    MarketingProjecsComponent,
    PopulatedProjecsComponent,
    HomeComponent,
    PersonalProjectComponent,
    PersonalProgressScheduleComponent,
    ManagementNoticesComponent,
    YearCheckedComponent,
    PersonalFileComponent,
    PersonalProjectsComponent,
    ProjectsInProcessComponent,
    ProjProcManajComponent,
    ContractorsComponent,
    SuppliersComponent,
    DocumentsComponent,
    TrackingLogComponent,
    CalculationTableComponent,
    ListOfTenantsComponent,
    ProgressScheduleComponent,
    RegisterComponent,
    PageNotFoundComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    RouterModule,
    BrowserAnimationsModule,
    MatSliderModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatMenuModule,
    MatTableModule,
    HttpClientModule,
    MatButtonModule
  ],
  providers: [PeopleService],
  bootstrap: [AppComponent]
})
export class AppModule { }
