using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class SituacaoFamiliar
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Situacao { get; set; }
        public virtual List<Kwendy> kwendy { get; set; }
    }
}