import { FormGroup, FormBuilder } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Cotacao } from 'src/app/models/Cotacao';

@Component({
  selector: 'app-cotacao',
  templateUrl: './cotacao.component.html',
  styleUrls: ['./cotacao.component.css']
})
export class CotacaoComponent implements OnInit {

  cadastroForm: FormGroup;
  cotacao: Cotacao;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.cadastroForm = this.fb.group({
      nome: [''],
      email: [''],
      marca: [''],
      valor: [''],
      opcionais: ['']
    })
  }
}
