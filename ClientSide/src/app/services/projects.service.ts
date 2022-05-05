import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Projects } from '../classes/projects';

@Injectable({
  providedIn: 'root'
})
export class ProjectsService {
  url:string="https://localhost:44371/api/Project/"
  project:Projects

  constructor(private http:HttpClient) { }

  getAllProjects():Observable<Array<Projects>>
  {
    return this.http.get<Array<Projects>>(this.url+"getAllProjects")
  }
}
