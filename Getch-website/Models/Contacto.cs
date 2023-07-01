using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Getch_website.Models
{
    public class Contacto
    {
        [ForeignKey("Apadrinhado")]
        public int ContactoId { get; set; }
        [Required]
        [StringLength(60)]
        public string Email { get; set; }
        [Required]
        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelefonePrimario { get; set; }
        [Required]
        [StringLength(14)]
        [RegularExpression(@"^[0-9]+$")]
        public string TelemovelSecundario { get; set; }
        public virtual Apadrinhado Apadrinhado { get; set; }
    }
}