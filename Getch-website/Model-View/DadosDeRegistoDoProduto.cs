using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDeRegistoDoProduto
    {
        public int ID { get; set; }
        public string NomePadrinho { get; set; }
        public string ApelidoPadrinho { get; set; }
        public string PadrinhoTelefone { get; set; }
        public string PadrinhoEmail { get; set; }
        public bool Anonimo { get; set; }

        [Required]
        public int IdAngariacaoDeProduto { get; set; }

        [Required]
        public string NomeDoproduto { get; set; }
        [Required]
        public decimal QuantidadeKg { get; set; }
        [Required]
        public decimal UnidadesCaixas { get; set; }
        [Required]
        public decimal UnidadesPacotes { get; set; }
        [Required]
        public DateTime DataDeValidade { get; set; }
        [Required]
        public int IdGeneroDeProduto { get; set; }
        [Required]
        public int IdCategoriaDoProduto { get; set; }
        [Required]
        public int IdEstadoDoProduto { get; set; }
        [Required]
        public int IdEstadoDeConservacaoDoProduto { get; set; }

        [Required]
        public int IdArmazen { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeRegisto { get; set; }
    }
}