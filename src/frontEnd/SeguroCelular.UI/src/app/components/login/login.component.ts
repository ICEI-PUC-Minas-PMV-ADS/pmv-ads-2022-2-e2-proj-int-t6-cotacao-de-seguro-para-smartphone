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

  emailDB: string = "email@teste.com";

  senhaDB: string = "12345678";

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
      this.router.navigate(["/home"]);
    } else {
      this.mensagem = "E-mail ou a senha estar errado!";
    }
  }
}
