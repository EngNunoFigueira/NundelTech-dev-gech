using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class TipoDePadrinho
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Descricao { get; set; }
        public virtual List<Padrinho> Padrinho { get; set; }
    }
}