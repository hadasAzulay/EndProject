import { Component, OnInit } from '@angular/core';
import { Projects } from '../classes/projects';

@Component({
  selector: 'app-projects-in-process',
  templateUrl: './projects-in-process.component.html',
  styleUrls: ['./projects-in-process.component.css']
})
export class ProjectsInProcessComponent implements OnInit {

  projects: Projects[];

  constructor() { }

  ngOnInit(): void {

  }

}
