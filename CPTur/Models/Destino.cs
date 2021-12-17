using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CPTur.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do destino")]
        [StringLength(30)]
        public string Nome { get; set; }
        [StringLength(15)]
        public string Tipo { get; set; }
        [StringLength(10)]
        public string Clima { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }

    }
}
