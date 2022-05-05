import { Component } from '@angular/core';
import { Router } from '@angular/router';
// import { read } from 'fs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
  
})

export class AppComponent {
  
  title = 'ClientSide';
  toggle = true;
  constructor(public router: Router)
{}
login()
{
 this.router.navigate(['/log-in']);
}
connection()
{
  this.router.navigateByUrl('/connection');
}
projects()
{
  this.router.navigateByUrl('/projects');
}
manager()
{
  this.router.navigateByUrl('/manager');
}
about()
{
  this.router.navigateByUrl('/about');
}
MarketingProjecs()
{
  this.router.navigateByUrl('/MarketingProjecs');
}
PopulatedProjecs()
{
  this.router.navigateByUrl('/PopulatedProjecs');
}
pricePerOccupant()
{
  this.router.navigateByUrl('/pricePerOccupant');
}
appComponent()
{
  this.router.navigateByUrl('/app');

}

PersonalProgressSchedule()
{
  this.router.navigateByUrl('/Personal-progressSchedule');

}
anagementNotices()
{
  this.router.navigateByUrl('/anagement-notices');

}
YearChecked()
{
  this.router.navigateByUrl('/YearChecked');

}
PersonalFile()
{
  this.router.navigateByUrl('/Personal-File');

}
personalProject()
{
  this.router.navigateByUrl('/personal-project');

}
ProjProcManaj()
{
  this.router.navigateByUrl('/ProjProcManaj');

}

Contractors()
{
  this.router.navigateByUrl('/Contractors');

}
Suppliers()
{
  this.router.navigateByUrl('/Suppliers');

}
Documents()
{
  this.router.navigateByUrl('/Documents');

}



}
