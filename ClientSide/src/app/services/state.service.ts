import { Injectable } from '@angular/core';
import { People } from '../classes/people';

@Injectable({
  providedIn: 'root'
})
export class StateService {

  currentUserValue: People = new People(1, 'יהודה', 'פינקו', '0501234567', 's@sample.com', '123456');

  constructor() { }

  isManager() {
    if (this.currentUserValue)
      return this.currentUserValue;
    return false;
  }
}
