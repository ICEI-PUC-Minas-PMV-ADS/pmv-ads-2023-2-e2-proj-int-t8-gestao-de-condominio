using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arpagen.Models
{
    [Table("Visitantes")]
    public class Visitante
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CPF!")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Bloco!")]
        public int Bloco { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Apartamento!")]
        public int Apartamento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Data!")]
        [DataType(DataType.Date)]
        public int Data { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Placa do Veiculo!")]
        public int placaVeiculo { get; set; }
    }
}
