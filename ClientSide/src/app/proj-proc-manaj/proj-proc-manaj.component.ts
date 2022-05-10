import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-proj-proc-manaj',
  templateUrl: './proj-proc-manaj.component.html',
  styleUrls: ['./proj-proc-manaj.component.css']
})
export class ProjProcManajComponent implements OnInit {

  projId: number = 1;

  constructor(public activeRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activeRoute.params.subscribe(p=>{
      this.projId = p['project'];
    });
  }

}
