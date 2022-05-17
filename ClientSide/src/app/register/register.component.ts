import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { Router } from '@angular/router';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})


export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  fnameFormControl = new FormControl('', [Validators.required]);
  lnameFormControl = new FormControl('', [Validators.required]);
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  phoneFormControl = new FormControl('', [Validators.pattern('05[0-8]-[0-9]{7}')]);
  pswFormControl = new FormControl('', [Validators.required, Validators.minLength(6)]);
  psw2FormControl = new FormControl('', [Validators.required, Validators.minLength(6)/*, Validators.suitable*/]);
  person: People;

  constructor(public peopleSvc: PeopleService, public router: Router) { }

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      'fnameFormControl': this.fnameFormControl,
      'lnameFormControl': this.lnameFormControl,
      'emailFormControl': this.emailFormControl,
      'phoneFormControl': this.phoneFormControl,
      'pswFormControl': this.pswFormControl,
      'psw2FormControl': this.psw2FormControl
    });
  }

  register() {
    this.person //= new People('',);
    this.peopleSvc.addPerson(this.person).subscribe(
      data => {
        this.router.navigate(['/personal-project'])
        // this.pSer.people=data;
      },
      err => { alert("no") }
    )
  }

}
