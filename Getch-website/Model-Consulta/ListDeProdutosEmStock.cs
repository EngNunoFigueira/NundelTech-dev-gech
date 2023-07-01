using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class ListDeProdutosEmStock
    {
        public int ID { get; set; }

        #region DADOS EXTRAIDOS DA TABELA PRODUTOS
        public string NomeDoProduto { get; set; }
        public string GeneroDoProduto { get; set; }
        public string CategoriaDoProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Unidades { get; set; }
        public decimal KilosPorUnidade { get; set; }
        public DateTime DataDeValidade { get; set; }
        public DateTime DataDeEntraDoArmazem { get; set; }
        #endregion

        #region DADOS EXTRAIDOS DA TABELA ARMAZEM
        public string NomeDoArmazem { get; set; }
        public string TelefoneDoArmazem { get; set; }
        #endregion
    }
}