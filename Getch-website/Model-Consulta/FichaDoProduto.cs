using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class FichaDoProduto
    {
        #region 
        public int ID { get; set; }
        #endregion

        #region DADOS EXTRAIDOS DA TABELA PRODUTO
        public string NomeDoProduto { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal QuantidadeKg { get; set; }
        public decimal UnidadesCaixas { get; set; }
        public decimal UnidadesPacotes { get; set; }
        public string GeneroDeProduto { get; set; }
        public string CategoriaDoProduto { get; set; }
        public string EstadoDeConservacaoDoProduto { get; set; }
        public string EstadoDoProdutoEmStock { get; set; }
        public DateTime DataDeAngariacao { get; set; }
        public string OrigemDoProduto { get; set; }
        #endregion

        #region DADOS EXTRAIDOS DA TABELA PADRINHO
        public string PadrinhoNome { get; set; }
        public string PadrinhoApelido { get; set; }
        #endregion
    }
}