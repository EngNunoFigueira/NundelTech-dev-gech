using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class MoradaDoPadrinho
    {
        [Required]
        public int ID { get; set; }
        public virtual Bairro Bairro { get; set; }
        [Required]
        public int BairroId { get; set; }
        [Required]
        public string RuaAvenida { get; set; }
        [Required]
        public string NumeroDaPorta { get; set; }
        [Required]
        public string CodigoPostal { get; set; }

        public virtual ICollection<Padrinho> Padrinho { get; set; }
    }
}