using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class InfoDosSitiosDeEmissaoDeDocumento
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int CodigDocumento { get; set; }

        [Required]
        public string Descricao { get; set; }

        public virtual List<BilheteDeIdentidade> BilhetesIdentidade { get; set; }
        public virtual List<CedulaPessoal> CedulaPessoal { get; set; }
    }
}