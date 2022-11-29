using System.ComponentModel.DataAnnotations;

namespace SeguroCelular.Mvc.Models.Enums
{
    public enum EPlanos
    {
        [Display(Name = "Plano Quebra")]
        Plano1,
        [Display(Name = "Plano Quebra + Roubo")]
        Plano2,
        [Display(Name = "Plano Quebra + Roubo + Furto")]
        Plano3
    }
}
