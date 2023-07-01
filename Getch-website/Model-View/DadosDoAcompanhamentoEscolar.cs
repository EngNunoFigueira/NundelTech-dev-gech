using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosDoAcompanhamentoEscolar
    {
        public int ID { get; set; }

        public int ClasseQueFrequenta { get; set; }
        public int AnoLectivo { get; set; }

        public int IdCicloFormativo { get; set; }
        public int IdInstituicaoDeEnsino { get; set; }
    }
}