import { Component } from '@angular/core';
import { User } from './models/User';
import { UsersService } from './services/users.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Users.UI';
  users: User[] = [];

  constructor(private userService: UsersService) {}

  ngOnInit() : void {
    this.userService
    .getUsers()
    .subscribe((result: User[]) => (this.users = result));
  }
}
