using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class ListaDePadrinhos
    {
        public int ID { get; set; }

        #region
        public string NomeDoPadrinho { get; set; }
        public string ApelidoDoPadrinho { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        #endregion

        #region
        public string Provincia { get; set; }
        public string TipoDePadrinho { get; set; }
        public DateTime DataDeAdesao { get; set; }
        public string GrauDeParticipacao { get; set; }
        #endregion

    }
}