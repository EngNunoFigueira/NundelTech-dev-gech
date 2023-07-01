using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class GrauDeParticipacao
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int CodigoParticipacao { get; set; }

        [Required]
        public string Descricao { get; set; }
      
        public virtual List<Apadrinhado> Apadrinhado { get; set; }
        public virtual List<Padrinho> Padrinho { get; set; }
    }
}