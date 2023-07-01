using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class ListaDeConsultasMedicas
    {
        public int ID { get; set; }

        #region Dados EXTRAIDOS DA TABELA Kwendy
        public string NomeKwendy { get; set; }
        public string ApelidoKwendy { get; set; }
        public string TelefoneKwendy { get; set; }
        #endregion

        #region Dados EXTRAIDOS DA TABELA ConsultaMedica
        public string NomeDoHospital { get; set; }
        public string HoraDaConsulta { get; set; }
        public DateTime DataDaConsulta { get; set; }
        public string NomeDoMedico { get; set; }
        public string ApelidoDoMedico { get; set; }
        public DateTime DataDeMarcao { get; set; }
        public string EstadoDaConsulta { get; set; }
        #endregion

        #region
        #endregion
    }
}