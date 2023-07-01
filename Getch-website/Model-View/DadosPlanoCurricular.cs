using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosPlanoCurricular
    {
        //[Required]
        public int ID { get; set; }

        public string NomeDaCrianca { get; set; }
        public string ApelidoDaCrianca { get; set; }

        public string DescricaoInstituicaoDeEnsino { get; set; }
        public string ClasseQueFrequenta { get; set; }
        public int AnoLectivo { get; set; }
        public string DescricaoCicloFormativo { get; set; }

        [Required]
        public int IdAcompanhamentoEscolar { get; set; }
        [Required]
        public int IdUnidadeCurrilcular { get; set; }

        public int NotaPrimeiroSemestre { get; set; }
        public int NotaSegundoSemestre { get; set; }
        public int NotaTerceiroSemestre { get; set; }
        public int TaxaAproveitamento { get; set; }
    }
}