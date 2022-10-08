import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  loginForm: any;

  emailDB: string = "teste@email.com";

  senhaDB: string = "123";

  mensagem: string = '';

  btnSignIn: any;

  constructor(private formBuilder: FormBuilder, private router: Router) {
    this.criarForm();
  }

  ngOnInit(): void {
  }

  criarForm() {
    this.loginForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      senha: ['', [Validators.required]]
    })
  }

  CadastrarUser() {

  }

  Login() {
    if (this.loginForm.get('email').value == this.emailDB && this.loginForm.get('senha').value == this.senhaDB) {
      alert('Login Realizado com Sucesso')
      this.router.navigate(["/cliente"]);
    } else {
      alert('Confira se seu e-mail ou senha está correto');
    }
  }
}
