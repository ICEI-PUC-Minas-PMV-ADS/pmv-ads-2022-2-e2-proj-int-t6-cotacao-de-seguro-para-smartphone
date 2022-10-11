using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SeguroCelular.Models
{
    [Table("Clientes")]
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(100)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(500)]
        public string Endereco { get; set; }
    }
}
