import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';
import { StateService } from '../services/state.service';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})

export class LogInComponent implements OnInit {

  loginForm: FormGroup;
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  minLenPhone: number = 6;
  pswFormControl = new FormControl('', [Validators.required, Validators.minLength(this.minLenPhone)])
  person: People;
  notFound: boolean = false;

  constructor(public peopleSvc: PeopleService, public state:StateService, public router: Router) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      'emailFormControl': this.emailFormControl,
      'pswFormControl': this.pswFormControl
    });
  }

  login() {
    this.peopleSvc.getByMailAndPas(this.emailFormControl.value, this.pswFormControl.value).subscribe(
      data => {
        this.state.currentUser.next(data);
        this.peopleSvc.isManager(data.PersonId).subscribe(ismng=> {
          if(ismng){
            this.state.isCurrentManager.next(true);
            this.router.navigate(['/manager/projects']);
          }
          else {
            this.state.isCurrentManager.next(false);
            this.router.navigate(['/personal-project']);
          }
        })
      },
      err => {
        //if(err == not fond user)
        console.log("not found user");
        this.notFound = true;       
        //if(err == no server)
        //console.log("no server");
      }
    )
  }
}

