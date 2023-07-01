using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class Provincia
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual List<Municipio> Municipio { get; set; }
    }
}