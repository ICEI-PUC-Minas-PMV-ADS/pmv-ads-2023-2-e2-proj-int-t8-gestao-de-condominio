using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Arpagen.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Bloco!")]
        public int Bloco { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Apartamento!")]
        public int Apartamento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Data!")]
        [DataType(DataType.Date)]
        public int Data { get; set; }

        public enum Perfil
        {
            ÁreaGourmet,
            Salão
        }
    }
}
