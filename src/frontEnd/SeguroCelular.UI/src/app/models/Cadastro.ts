export class Cadastro {
  constructor() {
    this.id = 0;
    this.nome = '';
    this.sobrenome = '';
    this.email = '';
    this.dataNascimento = '';
    this.endereco = '';
    this.senha = '';
    this.confirmeSenha = '';
  }

  id: number;
  nome: string;
  sobrenome: string;
  email: string;
  dataNascimento: string;
  endereco: string;
  senha: string;
  confirmeSenha: string;
}
