import { ToastrService } from 'ngx-toastr';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Cotacao } from 'src/app/models/Cotacao';
import { CotacaoService } from 'src/app/services/cotacao.service';

@Component({
  selector: 'app-cotacao',
  templateUrl: './cotacao.component.html',
  styleUrls: ['./cotacao.component.css']
})
export class CotacaoComponent implements OnInit {

  cotacaoForm: FormGroup;
  cotacao: Cotacao;

  constructor(private fb: FormBuilder,
    private cotacaoService: CotacaoService,
    private toastr: ToastrService
  ) {
    this.CotacaoForm();
  }

  ngOnInit(): void {

  }

  CotacaoForm() {
    this.cotacaoForm = this.fb.group({
      nome: [''],
      email: [''],
      marca: [''],
      valor: [0],
      opcionais: ['']
    });
  }

  NovoCadastro() {
    console.log(this.cotacaoForm.value);
    this.SalvarCotacao(this.cotacaoForm.value);
  }

  SalvarCotacao(cotacao: Cotacao) {
    this.cotacaoService.post(cotacao).subscribe(
      () => {
        this.toastr.success('Cotação realizada com sucesso!', 'Sucesso');
        this.CotacaoForm();
      },
      (erro: any) => {
        console.log(erro);
        this.toastr.error('Erro no formulrio', 'Falha');
      }
    );
  }
}
