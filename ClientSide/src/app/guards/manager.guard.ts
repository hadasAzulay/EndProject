import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { StateService } from '../services/state.service';

@Injectable({
  providedIn: 'root'
})
export class ManagerGuard implements CanActivate {

  constructor(
      private router: Router,
      private stateSvc: StateService
  ) { }

  canActivate() {
      const currentUser = this.stateSvc.isManager();
      if (currentUser) {
          // is manager return true
          return true;
      }

      // not manager redirect to register page
      this.router.navigate(['/register']);
      return false;
  }
  
}
