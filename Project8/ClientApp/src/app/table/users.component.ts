import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-users-component',
  templateUrl: './users.component.html'
})
export class UserComponent {
  public mans: UsersTable[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UsersTable[]>(baseUrl + 'ggaggs').subscribe(result => {
      this.mans = result;
    }, error => console.error(error));
  }
}

interface UsersTable {
  id: number;
  name: string;
}
