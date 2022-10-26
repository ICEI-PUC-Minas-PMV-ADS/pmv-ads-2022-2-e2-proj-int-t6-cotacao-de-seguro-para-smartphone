using System.ComponentModel.DataAnnotations;

namespace SeguroCelular.Mvc.Models.Enums
{
    public enum EValoresCelular
    {
        [Display(Name = "Até R$500")]
        Ate500,
        [Display(Name = "Entre R$501 e R$1000")]
        De501a1000,
        [Display(Name = "Entre R$1001 e R$2000")]
        De1001a2000,
        [Display(Name = "Entre R$2001 e R$3000")]
        De2001a3000,
        [Display(Name = "Entre R$3001 e R$4000")]
        De3001a4000,
        [Display(Name = "Entre R$4001 e R$5000")]
        De4001a5000,
        [Display(Name = "Acima de R$5000")]
        Acima5000
    }
}
