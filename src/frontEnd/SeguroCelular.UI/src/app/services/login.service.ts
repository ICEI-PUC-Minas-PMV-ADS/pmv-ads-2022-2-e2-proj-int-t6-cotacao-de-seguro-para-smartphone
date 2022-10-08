import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Login } from '../models/login';

const httpOptions = {
  headers: new HttpHeaders({
    'content-type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  url = 'https://63408d38e44b83bc73d27d70.mockapi.io/login'

  constructor(private http: HttpClient) { }

  NovoLogin(login: Login): Observable<any> {
    return this.http.post<Login>(this.url, login, httpOptions)
  }
}
