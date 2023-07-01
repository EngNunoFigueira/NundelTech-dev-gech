using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Getch_website.Models
{
    public class Pais
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }

        public int ContinenteId { get; set; }
        public virtual Continente Continente { get; set; }
        public virtual List<Provincia> Provincia { get; set; }
        public virtual List<Cidade> Cidade { get; set; }
    }
}