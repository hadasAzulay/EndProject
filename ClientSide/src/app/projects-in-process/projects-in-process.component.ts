import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-projects-in-process',
  templateUrl: './projects-in-process.component.html',
  styleUrls: ['./projects-in-process.component.css']
})
export class ProjectsInProcessComponent implements OnInit {

  projId: number = 1;

  constructor() { }

  ngOnInit(): void {
  }

}
