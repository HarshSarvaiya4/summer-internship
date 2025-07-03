import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  username="";
  password="";

  listen(){
    console.log("Username : "+this.username)
    console.log("Password : "+this.password)    
  }

}
