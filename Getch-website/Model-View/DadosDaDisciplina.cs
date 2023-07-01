using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDaDisciplina
    {
        [Required]
        public string CodigoApadrinhado { get; set; }
        [Required]
        public int IdNomeDaUC { get; set; }
        [Required]
        public int IdPlanoDeEstudo { get; set; }
        [Required]
        public int IdTipoSemestralOuAnual { get; set; }

        public decimal PSMedia { get; set; }
        public decimal SSMedia { get; set; }
        public decimal TSMedia { get; set; }
    }
}