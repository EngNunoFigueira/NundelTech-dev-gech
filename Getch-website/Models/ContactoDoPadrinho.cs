using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Getch_website.Models
{
    public class ContactoDoPadrinho
    {
        [ForeignKey("Padrinho")]
        public int ContactoDoPadrinhoId { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelefonePrimario { get; set; }
        [Required]
        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelemovelSecundario { get; set; }
        public virtual ICollection<Padrinho> Padrinho { get; set; }
    }
}