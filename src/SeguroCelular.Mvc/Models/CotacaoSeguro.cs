using SeguroCelular.Mvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SeguroCelular.Mvc.Models
{
    public class CotacaoSeguro
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Qual o modelo do seu celular?")]
        [Required(ErrorMessage = "Obrigatório Informar o modelo!")]
        public string ModeloCelular { get; set; }

        [Display(Name = "Qual o valor de mercado do seu celular?")]
        [Required(ErrorMessage = "Obrigatório Informar o valor!")]
        public EValoresCelular Valor { get; set; }

        [Display(Name = "Valor Mensal a ser pago")]
        public decimal ValorCotacao { get; set; }

        // Ef Relacionamento
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
