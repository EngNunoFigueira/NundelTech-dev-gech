using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Models
{
    public class FiltrosParaSelecaoDeDadosDeAdulto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Descricao { get; set; }
    }
}