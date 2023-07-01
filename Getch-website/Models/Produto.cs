using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class Produto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string NomeDoproduto { get; set; }
        [Required]
        public decimal QuantidadeKg { get; set; }
        [Required]
        public decimal UnidadesCaixas { get; set; }
        [Required]
        public decimal UnidadesPacotes { get; set; }
        [Required]
        public DateTime? DataDeValidade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataDeRegisto { get; set; }
        [Required]
        public bool EstadoDoProduto { get; set; }
        public string Fabricante { get; set; }
        public string PaisDeOrigem { get; set; }
        public bool DoadorAnonimo { get; set; }
        public bool ExistenciaProduto { get; set; }

        #region LIGACOES COM TABELAS 
        public virtual AngariacaoDeProduto AngariacaoDeProduto { get; set; }
        public int AngariacaoDeProdutoId { get; set; }
        public string CodigoPadrinho { get; set; }
        public virtual GeneroDeProduto GeneroDeProduto { get; set; }
        [Required]
        public int GeneroDeProdutoId { get; set; }
        public virtual CategoriaDoProduto CategoriaDoProduto { get; set; }
        [Required]
        public int CategoriaDoProdutoId { get; set; }
        public virtual EstadoDeConservacaoDoProduto EstadoDeConservacaoDoProduto { get; set; }
        [Required]
        public int EstadoDeConservacaoDoProdutoId { get; set; }
        #endregion
    }

}