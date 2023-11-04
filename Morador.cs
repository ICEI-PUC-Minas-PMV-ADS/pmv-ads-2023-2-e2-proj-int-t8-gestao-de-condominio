using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arpagen.Models
{
    [Table("Moradores")]
    public class Morador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o bloco!")]
        public int BlApartamento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Apartamento!")]
        public int NmApartamento { get; set; }


        public string Veículo { get;set; }
    }
}
