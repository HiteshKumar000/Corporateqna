import { Component, OnInit } from '@angular/core';
import { CategoryServiceService } from '../category-service.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {
  categoryList: any;
  constructor(private categoryService: CategoryServiceService) {}

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories() {
    this.categoryService.getCategories().subscribe(response => {
      this.categoryList = response;
    }, error => {
      console.log(error);
    })
  }

}
