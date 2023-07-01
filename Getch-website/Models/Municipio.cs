using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class Municipio
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int ProvinciaId { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual List<Bairro> Bairro { get; set; }
        public virtual List<InstitDeEnsino> Kescola { get; set; }
    }

}