import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.css']
})
export class ProjectsComponent implements OnInit {
  title = 'projects';
  constructor(public router: Router) { }
  MarketingProjecs()
  {
   this.router.navigate(['/MarketingProjecs']);
  }
  PopulatedProjecs()
  {
    this.router.navigate(['/PopulatedProjecs']);
  }
  pricePerOccupant()
   {
    this.router.navigate(['/pricePerOccupant']);
   }
  ngOnInit(): void {
  }

}
