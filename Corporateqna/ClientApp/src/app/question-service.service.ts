import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class QuestionServiceService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/question';


  getQuestions() {
    return this.http.get(this.baseURL);
  }
}
