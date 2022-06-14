import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { People } from '../classes/people';
import { PeopleService } from '../services/people.service';
import { StateService } from '../services/state.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})


export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  fnameFormControl = new FormControl('', [Validators.required]);
  lnameFormControl = new FormControl();
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  phoneFormControl = new FormControl('', [Validators.pattern('05[0-8][0-9]{7}')]);
  pswFormControl = new FormControl('', [Validators.required, Validators.minLength(6)]);
  pswConfirmFormControl = new FormControl('', [Validators.required, Validators.minLength(6)]);
  projFormControl = new FormControl();
  projects: any[] = ['מחיר למשתכן - בני ברק', 'מחיר למשתכן - חיפה', 'שיכון - פרויקטA'];
  person: People;

  matchPassword(password: string, confirmPassword: string) {
    return (formGroup: FormGroup) => {
      const passwordControl = formGroup.controls[password];
      const confirmPasswordControl = formGroup.controls[confirmPassword];

      if (!passwordControl || !confirmPasswordControl) {
        return null;
      }

      if (confirmPasswordControl.errors && !confirmPasswordControl.errors.passwordMismatch) {
        return null;
      }

      if (passwordControl.value !== confirmPasswordControl.value) {
        confirmPasswordControl.setErrors({ passwordMismatch: true });
      } else {
        confirmPasswordControl.setErrors(null);
      }
    }
  }

  constructor(public peopleSvc: PeopleService,
    public state: StateService,
    public router: Router) { }

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      'fnameFormControl': this.fnameFormControl,
      'lnameFormControl': this.lnameFormControl,
      'emailFormControl': this.emailFormControl,
      'phoneFormControl': this.phoneFormControl,
      'pswFormControl': this.pswFormControl,
      'pswConfirmFormControl': this.pswConfirmFormControl,
      'projFormControl': this.projFormControl
    },
      { validators: this.matchPassword('pswFormControl', 'pswConfirmFormControl'), });
  }

  register(content) {
    this.person = new People(0, this.fnameFormControl.value, this.lnameFormControl.value,
      this.phoneFormControl.value, this.emailFormControl.value, this.pswFormControl.value);
    this.peopleSvc.addPerson(this.person).subscribe(
      data => {
        this.state.currentUser.next(data);
        this.peopleSvc.isManager(data.PersonId).subscribe(ismng => {
            if (ismng) {
              this.state.isCurrentManager.next(true);
              this.router.navigate(['/manager/projects']);
            }
            else {
              this.state.isCurrentManager.next(false);
              this.router.navigate(['/personal-project']);
            }
          });

      },
      err => { console.log("no") }
    )
  }

}
