import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Cadastro } from 'src/app/models/Cadastro';

@Component({
  selector: 'app-cadastro-cliente',
  templateUrl: './cadastro-cliente.component.html',
  styleUrls: ['./cadastro-cliente.component.css']
})
export class CadastroClienteComponent implements OnInit {

  cadastro: Cadastro;
  telacadastroForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private toastr: ToastrService,
    private router: Router) {
    this.CriarForm();
  }

  ngOnInit(): void {
  }

  CriarForm() {
    this.telacadastroForm = this.fb.group({
      id: 0,
      cPF: ['', Validators.required],
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      email: ['', Validators.required],
      dataNascimento: ['', Validators.required],
      endereco: ['', Validators.required],
      senha: ['', Validators.required],
      confimeSenha: ['', Validators.required]
    });
  }

  NovoCadastro() {
    console.log('Novo cadastro')
    this.router.navigate(["/home"]);
  }

  SalvarCadastro() { }

}
