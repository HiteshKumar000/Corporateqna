import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AnswerServiceService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/answer';


  getAnswers() {
    return this.http.get(this.baseURL);
  }
}
