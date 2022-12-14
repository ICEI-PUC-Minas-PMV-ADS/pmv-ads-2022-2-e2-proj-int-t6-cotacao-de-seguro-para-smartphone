import { CadastroClienteComponent } from './components/cadastro-cliente/cadastro-cliente.component';
import { AvaliacoesComponent } from './components/avaliacoes/avaliacoes.component';
import { SobreComponent } from './components/sobre/sobre.component';
import { LoginComponent } from './components/login/login.component';
import { CotacaoComponent } from './components/cotacao/cotacao.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { ClienteComponent } from './components/cliente/cliente.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'cotacao', component: CotacaoComponent },
  { path: 'login', component: LoginComponent },
  { path: 'sobre', component: SobreComponent },
  { path: 'avaliacoes', component: AvaliacoesComponent },
  { path: 'cadastro-cliente', component: CadastroClienteComponent },
  { path: 'cliente', component: ClienteComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
