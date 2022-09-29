import { HomeComponent } from './components/home/home.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './shared/nav/nav.component';
import { FooterComponent } from './shared/footer/footer.component';
import { CotacaoComponent } from './components/cotacao/cotacao.component';
import { LoginComponent } from './components/login/login.component';
import { SobreComponent } from './components/sobre/sobre.component';
import { AvaliacoesComponent } from './components/avaliacoes/avaliacoes.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    FooterComponent,
    CotacaoComponent,
    LoginComponent,
    SobreComponent,
    AvaliacoesComponent
  ],
  imports: [
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserModule
  ],
  exports: [
    NavComponent,
    FooterComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
