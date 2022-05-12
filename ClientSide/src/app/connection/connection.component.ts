import { Component, OnInit } from '@angular/core';
// import{FormsModule}from '@angular/forms'
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { Router } from '@angular/router';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';


export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
@Component({
  selector: 'app-connection',
  templateUrl: './connection.component.html',
  styleUrls: ['./connection.component.css']
})
export class ConnectionComponent implements OnInit {
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  phoneFormControl = new FormControl('', [ Validators.pattern('05[0-8]-[0-9]{7}')]);
  
  matcher = new MyErrorStateMatcher();
  constructor(public pSer:PeopleService, public router:Router) { }
  person:People

  ngOnInit(): void {
  }
  ok()
  {
  this.pSer.addPerson(this.person).subscribe(
    // this.pSer.people=data;
    data=>{this.router.navigate(['/personal-project'])
  },
    err=>{alert("no")}
  )
  }
}
