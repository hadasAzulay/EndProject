import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { StateService } from '../services/state.service';

@Injectable({
  providedIn: 'root'
})
export class ManagerGuard implements CanActivate {

  isManager:boolean;

  constructor(
      private router: Router,
      private stateSvc: StateService
  ) { }

  canActivate() {
      this.stateSvc.isCurrentManager.subscribe(data => { 
        this.isManager = data;
      });
      return true//this.isManager;
  }
  
}
