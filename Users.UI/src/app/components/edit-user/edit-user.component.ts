import { Component, Input, OnInit } from '@angular/core';
import { User } from 'src/app/models/User';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
@Input() user: User | undefined;

  constructor() { }

  ngOnInit(): void {
  }

  updateUser(user: User) {

  }

  deleteUser(user: User) {
    
  }

  createUser(user: User){
    
  }

  

}
