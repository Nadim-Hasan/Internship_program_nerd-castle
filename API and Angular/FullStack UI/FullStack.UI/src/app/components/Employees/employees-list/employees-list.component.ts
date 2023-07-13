import { Component ,OnInit} from '@angular/core';
import { Employee } from './../../../models/employee.model';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  employee: Employee[] =[

   { id : 'ajgwraf',
    name: 'nadim',
    email: 'nadimhasan753990@gmail.com',
    phone: 1796753990,
    salary: 5000000,
    department: 'nothing but a bad thing is fornend'
  }
  ]

  constructor(){}
  ngOnInit(): void {
      this.employee.push();

  } 

}
