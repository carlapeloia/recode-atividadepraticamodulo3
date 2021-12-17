using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CPTur.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o assunto: Contato ou Orçamento")]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "Informe seu nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe seu e-mail")]
        public string Email { get; set; }
        [StringLength(1)]
        public string QtPessoas { get; set; }
        [StringLength(30)]
        public string Destino { get; set; }
        [StringLength(200)]
        public string Mensagem { get; set; }

    }
}
