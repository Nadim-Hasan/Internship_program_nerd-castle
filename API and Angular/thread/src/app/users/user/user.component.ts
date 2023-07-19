import { Component,EventEmitter,Input, Output } from '@angular/core';
import { UserModel } from './../../models/user.model';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent {

  @Input() user!: UserModel;
  @Output() handleUserClick= new EventEmitter(); 

  onUserSelect(user:UserModel){
    //console.log(user);
    this.handleUserClick.emit(user); 
  }

}
