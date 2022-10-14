import { Cotacao } from 'src/app/models/Cotacao';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CotacaoService {

  url = "https://63408d38e44b83bc73d27d70.mockapi.io/cotacao";

  constructor(private http: HttpClient) { }

  post(cotacao: Cotacao) {
    return this.http.post(`${this.url}`, cotacao)
  }
}
