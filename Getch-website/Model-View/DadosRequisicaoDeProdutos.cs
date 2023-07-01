using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosRequisicaoDeProdutos
    {
        [Required]
        [StringLength(200)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataDeAbertura { get; set; }
        public DateTime DataDeFecho { get; set; }

        [Required]
        public int IdDoProduto { get; set; }

        [Required]
        public int Quantidade { get; set; }
        [Required]
        public int IdEstadoDaRequisicao { get; set; }

        [Required]
        public string CodigoColaborador   { get; set; }
        public string CodigoApadrinhado   { get; set; }
        public string NomeApadrinhado     { get; set; }
        public string ApelidoApadrinhado  { get; set; }
        public string TelefoneApadrinhado { get; set; }
    }
}