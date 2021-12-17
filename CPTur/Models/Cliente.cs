using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CPTur.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(15)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Informe o telefone do cliente")]
        [StringLength(20)]
        public string Telefone { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(20)]
        public string EstadoCivil { get; set; }

    }
}
