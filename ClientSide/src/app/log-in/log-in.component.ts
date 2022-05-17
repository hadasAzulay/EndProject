import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { FormControl, Validators } from '@angular/forms';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})

export class LogInComponent implements OnInit {

  loginForm: FormGroup;
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  pswFormControl = new FormControl('', [Validators.required, Validators.minLength(6)])
  person: People;
  notFound: boolean = false;

  constructor(public peopleSvc: PeopleService, public router: Router) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      'emailFormControl': this.emailFormControl,
      'pswFormControl': this.pswFormControl
    });
  }

  login() {
    this.peopleSvc.getByMailAndPas(this.emailFormControl.value, this.pswFormControl.value).subscribe(
      data => {
        this.peopleSvc.thisPerson = data;
        //if(isManager())
        this.router.navigate(['/personal-project']);
      },
      err => {
        console.log("not found user");
        this.notFound = true;
      }
    )
  }
}

