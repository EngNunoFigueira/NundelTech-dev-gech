using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class ListaDeRequisicoes
    {
        public int ID { get; set; }

        #region Dados extraidos da Tabela Requisicoes
        public string Descricao { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public DateTime DataDeFecho { get; set; }
        public string Produto { get; set; }
        public decimal Quantidade { get; set; }
        public string EstadoDaRequisicao { get; set; }
        #endregion

        #region Dados Extraidos da Tabla Apadrinhado
        public string NomeDoApadrinhado { get; set; }
        public string ApelidoDoApadrinhado { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Dados extraidos da Tabla Colaborador
        public string ApelidoDoColaborador { get; set; }
        public string NomeDoColaborador { get; set; }
        #endregion
    }
}