import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  private url = "Users"
  constructor(private http: HttpClient) { }

  //Get Static Data
  // public getUser() : User[] {
  //   let user = new User();
  //   user.id = 1;
  //   user.firstName = "mockDataFirstName";
  //   user.lastName = "mockDataLastName";

  //   return [user]
  // }

  public getUsers() : Observable<User[]>  {
    return this.http.get<User[]>(`${environment.baseApiUrl}/${this.url}`);
  }

  public getUser(id: number) : Observable<User> {
    return this.http.get<User>(`${environment.baseApiUrl}/${this.url}/${id}`);
  }

}
