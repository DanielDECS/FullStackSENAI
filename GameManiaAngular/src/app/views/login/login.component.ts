import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  router: any;

  constructor(private loginService: LoginService) { }

  ngOnInit(): void {
  }

  userModel = new User()
  message = ""

  receiveData() {
    console.log("Modelo: ", this.userModel)

    // Verificação de segurança para prevenir SQL Injection
    const wordsList: string[] = ["select ", "from ", "drop ", "or ", "having ", "group ", "by ", "insert ", "exec ", "\"", "\'", "--", "#", "*", ";"]

    wordsList.forEach(word => {
      if(this.userModel.email?.toLowerCase().includes(word)) {
        this.message = "Dados inválidos " + "( " + word + " )"
        return;
      }
    })

    // Enviar dados para a API
    this.loginService.login(this.userModel).subscribe((response) => {
      console.log("response: ", response);
      console.log("O status code é: ", response.status);
      console.log("O token de permissão é: ", response.body.acessToken);

      this.message = "Bem vindo " + response.body.user.nome + "!"
      console.log(this.message);
      this.router.navigateByUrl('/')

    }, (error) => {
      console.log("error: ", error);
      this.message = "Ocorreu um erro, tente novamente! " + " ( " + error.error + " ) ";

    })
  }
}
