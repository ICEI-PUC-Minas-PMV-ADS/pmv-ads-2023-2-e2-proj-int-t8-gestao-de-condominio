using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Arpagen.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o senha")]
        public Perfil Perfil { get; set; }
    }
    public enum Perfil
    {
        Admin,
        User
    }
}
