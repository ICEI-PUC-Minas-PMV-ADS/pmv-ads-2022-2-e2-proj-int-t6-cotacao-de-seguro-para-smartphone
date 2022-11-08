using SeguroCelular.Mvc.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeguroCelular.Mvc.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Deixe seu comentário")]
        [Required(ErrorMessage = "Obrigatório deixar um comentário")]
        public string Comentario { get; set; }

        [Display(Name = "Qual sua nota?")]
        [Required(ErrorMessage = "Obrigatório dar uma nota")]
        public ENotaAvaliacao Nota { get; set; }

        public int UserId { get; set; }
        public int CotacaoSeguroId { get; set; }

        //Relacionamentos EF

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CotacaoSeguroId")]
        public CotacaoSeguro CotacaoSeguro { get; set; }
    }
}
