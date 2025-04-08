using System.ComponentModel.DataAnnotations;

namespace FinCheck.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O tipo da transação é obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(100, ErrorMessage ="A descrição deve ter no máximo 100 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor é  obrigatório")]
        [Range(0.01, double.MaxValue,ErrorMessage = "O valor deve ser maior que zero.")]
        public decimal Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;


    }
}
