using SeguroCelular.Domain.ValueObjects;

namespace SeguroCelular.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Endereco Endereco { get; private set; }

        public Cliente(string nome, string sobrenome, string cpf, DateTime dataNascimento, Endereco endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }
    }
}
