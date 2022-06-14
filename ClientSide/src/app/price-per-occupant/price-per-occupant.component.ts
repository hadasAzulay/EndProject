import { Component, OnInit, Output } from '@angular/core';
import { Projects } from '../classes/projects';

@Component({
  selector: 'app-price-per-occupant',
  templateUrl: './price-per-occupant.component.html',
  styleUrls: ['./price-per-occupant.component.css']
})
export class PricePerOccupantComponent implements OnInit {

  projects: Projects[];
  
  constructor() { }

  ngOnInit(): void {
  }

}
