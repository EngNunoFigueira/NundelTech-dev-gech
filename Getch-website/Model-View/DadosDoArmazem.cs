using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDoArmazem
    {
        [Required]
        [StringLength(150)]
        public string NomeDoArmazem { get; set; }

        public Int32 BairroId { get; set; }
        [Required]
        public string RuaAvenida { get; set; }
        [Required]
        public string NumeroDaPorta { get; set; }
        [Required]
        public string CodigoPostal { get; set; }

        [Required]
        public string CodigoColaboradorGerente { get; set; }

        [Required]
        [StringLength(14)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(14)]
        public string Skype { get; set; }

        [Required]
        public int IdEstadoDoArmazem { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeAbertura { get; set; }
    }
}