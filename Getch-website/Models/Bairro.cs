using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class Bairro
    {

        [Required]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        public virtual Municipio Municipio { get; set; }

        [Required]
        public virtual int  IdMunicipio { get; set; }

        public virtual List<Morada> Morada { get; set; }
        public virtual List<MoradaDoPadrinho> MoradaDoPadrinho { get; set; }
    }

}