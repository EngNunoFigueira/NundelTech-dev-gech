using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class EstadoCivil
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int CodigoEstadoCivil { get; set; }

        [Required]
        [StringLength(20)]
        public string Descricao { get; set; }

        public virtual List<BilheteDeIdentidade> BilhetesIdentidade { get; set; }
    }
}