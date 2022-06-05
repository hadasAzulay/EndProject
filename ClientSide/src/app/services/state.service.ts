import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { People } from '../classes/people';

@Injectable({
  providedIn: 'root'
})
export class StateService {

  currentUser: Subject<People> = new Subject<People>();
  isCurrentManager: Subject<boolean> = new Subject<boolean>();

  constructor() {
    this.currentUser.next(new People(1, 'יהודה', 'פינקו', '0501234567', 's@sample.com', '123456'));
    this.isCurrentManager.next(false);
   }

}
