import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';
import { ErrorStateMatcher } from '@angular/material/core';
import { FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';

// import { Router } from '@angular/router';
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})

export class LogInComponent implements OnInit {
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  checkoutForm: FormGroup;
  person: People;

  constructor(public pSer: PeopleService, public router: Router) { }

  ngOnInit(): void {
  }

  login() {
    this.pSer.getByMailAndPas(this.person.Email, this.person.PsWord).subscribe(
      data => {
        this.pSer.people = data;
        this.router.navigate(['/personal-project']);
      },
      err => { alert("no") }
    )
  }
}

