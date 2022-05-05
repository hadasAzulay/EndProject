import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tracking-log',
  templateUrl: './tracking-log.component.html',
  styleUrls: ['./tracking-log.component.css']
})
export class TrackingLogComponent implements OnInit {
  displayedColumns = ['Notes','Alerts','workinghours','Contractor ','Materials ','Equipment ','Tools ','Detailswork','Date '];
  dataSource = ELEMENT_DATA;

  constructor() { }

  ngOnInit(): void {
  }
  
 
}
export interface PeriodicElement {
  Date:string
  Detailswork:string
  Tools:string
  Equipment:string
  Materials:string
  Contractor:string;
  workinghours: string;
  Alerts: string;
  Notes: string;
}
const ELEMENT_DATA: PeriodicElement[] = [
  {Date:'fghbjkl ', Detailswork: ' z', Tools: ' fgh', Equipment: 'bn ',Materials:' bnm',Contractor:' cvbn',workinghours:' vbn',Alerts:'hnj',Notes:'ghjn'}
  
];