import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/user';


  getSeats() {
    return this.http.get(this.baseURL);
  }

}
