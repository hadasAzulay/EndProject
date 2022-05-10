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
import { ProjectsInProcessComponent } from './projects-in-process/projects-in-process.component';
import { ManagerGuard } from './guards/manager.guard';


const routes: Routes = [
  { path: 'manager', component: MainManagerComponent, canActivate: [ManagerGuard] },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'log-in', component: LogInComponent },
  { path: 'projects', component: ProjectsComponent },
  { path: 'connection', component: ConnectionComponent },
  { path: 'about', component: AboutUsComponent },
  { path: 'MarketingProjecs', component: MarketingProjecsComponent },
  { path: 'PopulatedProjecs', component: PopulatedProjecsComponent },
  { path: 'pricePerOccupant', component: PricePerOccupantComponent },
  { path: 'personal-project', component: PersonalProjectComponent },
  { path: 'Personal-progressSchedule', component: PersonalProgressScheduleComponent },
  { path: 'anagement-notices', component: ManagementNoticesComponent },
  { path: 'YearChecked', component: YearCheckedComponent },
  { path: 'Personal-File', component: PersonalFileComponent },
  { path: 'Personal-projects', component: PersonalProjectsComponent },
  { path: 'manager/projects', component: ProjectsInProcessComponent, canActivate: [ManagerGuard] },
  { path: 'manager/projects/:project', component: ProjProcManajComponent, canActivate: [ManagerGuard] },
  { path: 'manager/contractors', component: ContractorsComponent, canActivate: [ManagerGuard] },
  { path: 'manager/suppliers', component: SuppliersComponent, canActivate: [ManagerGuard] },
  { path: 'manager/documents', component: DocumentsComponent, canActivate: [ManagerGuard] },
  { path: 'manager/projects/:project/tracking-log', component: TrackingLogComponent, canActivate: [ManagerGuard] },
  { path: 'manager/projects/:project/calculation-table', component: CalculationTableComponent, canActivate: [ManagerGuard] },
  { path: 'manager/projects/:project/teanants-list', component: ListOfTenantsComponent, canActivate: [ManagerGuard] },
  { path: 'manager/projects/:project/progress-schedule', component: ProgressScheduleComponent, canActivate: [ManagerGuard] },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
