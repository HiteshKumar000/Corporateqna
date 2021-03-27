import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoryServiceService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/category';


  getCategories() {
    return this.http.get(this.baseURL);
  }
}
