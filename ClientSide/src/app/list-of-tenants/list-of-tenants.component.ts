import { Component, OnInit } from '@angular/core';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';

@Component({
  selector: 'app-list-of-tenants',
  templateUrl: './list-of-tenants.component.html',
  styleUrls: ['./list-of-tenants.component.css']
})
export class ListOfTenantsComponent implements OnInit {
person:Array<People> 
  constructor(private personService:PeopleService) { }

  ngOnInit(): void {
    //עלינו למלא את הרשימה בעת טעינת הקומפוננטה
 this.personService.getAllPeople().
 subscribe(data=>{this.person=data;console.log(this.person)},err=>{alert("בעיה בגישה לשרת")});
  }

}
