import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor( private loginService: LoginService ) { }

  ngOnInit(): void {
  }

  userModel = new User()
  message = ""

  receiveData() {
    console.log(this.userModel)

    // Enviar dados para a API
    this.loginService.login(this.userModel).subscribe( (response) => {
      console.log("response: ", response);
      console.log("O status code é: ", response.status);
      console.log("O token de permissão é: ", response.body.acessToken);

      this.message = "Bem vindo " + response.body.user.nome + "!"
      console.log(this.message);

    }, (error) => {
      console.log("error: ", error);
      this.message = "Ocorreu um erro, tente novamente! " + " ( " + error.error + " ) ";
      // this.message = "Ocorreu um erro, tente novamente ! " + error.error;

    })
  }

}
