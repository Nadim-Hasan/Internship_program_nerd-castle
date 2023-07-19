import { Component } from '@angular/core';
import { UserModel } from './models/user.model';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({     //component decorator 
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})


export class AppComponent {
  title = 'List of users ';
  users :UserModel[]=[]; 
  selectedUser! :UserModel;
  

constructor(private httpClient: HttpClient){
}

ngOnInit():void{

  this.httpClient.get<any>
  ("https://reqres.in/api/users?page=2")
  .subscribe(res=> {
    this.users! =res.data;
  })

  };
  


  onUserSelect(user: UserModel){
    console.log(user);
    this.selectedUser = user;
  }
}


