using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_Consulta
{
    public class FichaMedicaDoKwendy
    {
        [Required]
        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        public string RelatorioMedico { get; set; }
        public decimal PesoActual { get; set; }
        public decimal Altura { get; set; }

        public string CodigoUtente { get; set; }
        public string Alergias { get; set; }
        public string PrimeiraAlergia { get; set; }
        public string SegundaAlergia { get; set; }
        public string TerceiraAlergia { get; set; }
        public string QuartaAlergia { get; set; }

        public string Fracturas { get; set; }
        public string Perna { get; set; }
        public string Bracos { get; set; }
        public string Cabeca { get; set; }
        public string Coluna { get; set; }

        public string ProblemasDeVisao { get; set; }
        public string GraduacaoActual { get; set; }
        public string DoencasHereditaria { get; set; }
        public string PrimeiraDoencasHereditaria { get; set; }
        public string SegundaDoencasHereditaria { get; set; }
        public string TerceiraDoencasHereditaria { get; set; }
        public string QuartaDoencasHereditaria { get; set; }

        public string CirugiasRealizadas { get; set; }
        public string PrimeiraCirugia { get; set; }
        public string SegundaCirugia { get; set; }
        public string TerceiraCirugia { get; set; }
        public string QuartaCirugia { get; set; }

        public string EstadoPsicologico { get; set; }
        public int IdKwendy { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataAbertura { get; set; }
    }
}