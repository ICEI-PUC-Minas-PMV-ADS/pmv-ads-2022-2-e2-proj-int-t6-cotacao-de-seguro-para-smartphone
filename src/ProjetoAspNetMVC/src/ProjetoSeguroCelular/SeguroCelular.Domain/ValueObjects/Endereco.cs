using SeguroCelular.Domain.Enums;

namespace SeguroCelular.Domain.ValueObjects
{
    public class Endereco
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public Estados Estado { get; private set; }
        public string Pais { get; private set; }

        public Endereco(string rua, string numero, string bairro, string cidade, Estados estado, string pais)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }
    }
}
