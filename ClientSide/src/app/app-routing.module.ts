import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainManagerComponent } from './main-manager/main-manager.component';
import { LogInComponent } from './log-in/log-in.component';
import { ProjectsComponent } from './projects/projects.component';
import { ConnectionComponent } from './connection/connection.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { MarketingProjecsComponent } from './marketing-projecs/marketing-projecs.component';
import { PopulatedProjecsComponent } from './populated-projecs/populated-projecs.component';
import { PricePerOccupantComponent } from './price-per-occupant/price-per-occupant.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PersonalProjectComponent } from './personal-project/personal-project.component';
import { PersonalProgressScheduleComponent } from './personal-progress-schedule/personal-progress-schedule.component';
import { ManagementNoticesComponent } from './management-notices/management-notices.component';
import { YearCheckedComponent } from './year-checked/year-checked.component';
import { PersonalFileComponent } from './personal-file/personal-file.component';
import { PersonalProjectsComponent } from './personal-projects/personal-projects.component';
import { ProjProcManajComponent } from './proj-proc-manaj/proj-proc-manaj.component';
import { ContractorsComponent } from './contractors/contractors.component';
import { SuppliersComponent } from './suppliers/suppliers.component';
import { DocumentsComponent } from './documents/documents.component';
import { TrackingLogComponent } from './tracking-log/tracking-log.component';
import { CalculationTableComponent } from './calculation-table/calculation-table.component';
import { ListOfTenantsComponent } from './list-of-tenants/list-of-tenants.component';
import { ProgressScheduleComponent } from './progress-schedule/progress-schedule.component';




const routes: Routes = [
  { path:'manager',component:MainManagerComponent },
  { path:'',component:HomeComponent },
  { path:'app',component:HomeComponent },
  { path:'log-in',component:LogInComponent},
  { path:'projects',component:ProjectsComponent },
  { path:'connection',component:ConnectionComponent },
  { path:'about',component:AboutUsComponent },
  { path:'MarketingProjecs',component:MarketingProjecsComponent },
  { path:'PopulatedProjecs',component:PopulatedProjecsComponent },
  { path:'pricePerOccupant',component:PricePerOccupantComponent },
  { path:'personal-project' ,component:PersonalProjectComponent },
  { path:'Personal-progressSchedule' ,component:PersonalProgressScheduleComponent },
  { path:'anagement-notices' ,component:ManagementNoticesComponent },
  { path:'YearChecked' ,component:YearCheckedComponent },
  { path:'Personal-File' ,component:PersonalFileComponent },
  { path:'Personal-projects' ,component:PersonalProjectsComponent },
  { path:'ProjProcManaj' ,component:ProjProcManajComponent },
  { path:'Contractors' ,component:ContractorsComponent },
  { path:'Suppliers' ,component:SuppliersComponent },
  { path:'Documents' ,component:DocumentsComponent },
  { path:'TrackingLog' ,component:TrackingLogComponent },
  { path:'CalculationTable' ,component:  CalculationTableComponent},
  { path:'ListOfTenants' ,component:  ListOfTenantsComponent},
  { path:'ProgressSchedule' ,component: ProgressScheduleComponent},




  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
