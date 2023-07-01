using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class FichaPessoalDoApadrinhado
    {
        public int ID { get; set; }

        #region NOME E APELIDO
        public string NomeDoPadrinho { get; set; }
        public string ApelidoDoPadrinho { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public byte[] Fotografia { set; get; }
        #endregion

        #region CONTACTOS
        public string Email { get; set; }
        public string TelefonePrimario { get; set; }
        public string TelemovelSecundario { get; set; }
        #endregion

        #region MORADA
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string Bairro    { get; set; }
        public string Morada { get; set; }
        public string NumeroDaPorta { get; set; }
        #endregion

        #region IDENTIDADE
        public string TipoDocumento { get; set; }
        public string NumeroDoDocumento { get; set; }
        #endregion

        #region DADOS SOCIAIS
        public int NumeroDeFilhos { get; set; }
        public int CriancasACargo { get; set; }
        public string Formacao { get; set; }
        public string Profissao { get; set; }
        public string SituacaoLaboral { get; set; }
        #endregion

        #region DADOS DE ASSOCIADO
        public string TipoDeAPadrinho { get; set; }
        public DateTime DataDeAdesao { get; set; }
        public string GrauDeParticipacao { get; set; }
        #endregion
    }
}