using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class ListaDeEventos
    {
        public int ID { get; set; }

        #region DADOS EXTRAIDOS DA TABELA Evento
        public string NomeDoEvento { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public int NumeroDeParticipantes { get; set; }
        public int ToneladasAdquiridas { get; set; }
        public DateTime DataDeRealizacao { get; set; }
        public string HoraRealizada { get; set; }
        public string EstadoDoEvento { get; set; }
       
        #endregion

        #region DADOS EXTRAIDOS DA TABELA Coladoradores
        public string NomeDoResponsavel { get; set; }
        public string ApelidoDoResponsavel { get; set; }
        #endregion
    }
}

