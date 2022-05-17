import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { People } from '../classes/people';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {
  //נגדיר משתנה עם הכתובת של השרת
  url: string = 'https://localhost:44371/api/Person/';
  thisPerson: People;
  //בסרוויס ניצור פונקציות מקבילות לפונקציות בקונטרולר
  constructor(private http: HttpClient) { }
  //פונקציה שמבצעת קריאה לפונקציה בשרת ששולפת את כל האנשים
  getAllPeople(): Observable<Array<People>>
  /// Observable/כאשר מחזירים משהו ממסד הנתונים זה מחזיר 
  {
    ///http/משתנה המאפשר גישה עם השרת 
    return this.http.get<Array<People>>(this.url + 'GetAllPerson')
  }
  getByMailAndPas(mail: string, password: string): Observable<People> {
    return this.http.get<People>(this.url + 'getPersonByEmailAndPas/' + mail +'/'+ password)
  }
  addPerson(people: People): Observable<Array<People>> {
    return this.http.put<Array<People>>(this.url + 'putPerson', people)
  }
}
