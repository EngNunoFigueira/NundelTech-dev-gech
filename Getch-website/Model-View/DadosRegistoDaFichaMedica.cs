using Getch_website.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Getch_website.Model_View
{
    public class DadosRegistoDaFichaMedica
    {
        [Required]
        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        public string RelatorioMedico { get; set; }
        [Required]
        public decimal PesoActual { get; set; }
        [Required]
        public decimal Altura { get; set; }

        [Required]
        public string CodigoUtente { get; set; }

        [Required]
        public bool Alergias { get; set; }
        [StringLength(200)]
        public string PrimeiraAlergia { get; set; }
        [StringLength(200)]
        public string SegundaAlergia { get; set; }
        [StringLength(200)]
        public string TerceiraAlergia { get; set; }
        [StringLength(200)]
        public string QuartaAlergia { get; set; }

        public bool Fracturas { get; set; }
        [StringLength(200)]
        public string Perna { get; set; }
        [StringLength(200)]
        public string Bracos { get; set; }
        [StringLength(200)]
        public string Cabeca { get; set; }
        [StringLength(200)]
        public string Coluna { get; set; }

        [Required]
        public bool ProblemasDeVisao { get; set; }
        [StringLength(200)]
        public string GraduacaoActual { get; set; }

        [Required]
        public bool DoencasHereditaria { get; set; }
        [StringLength(70)]
        public string PrimeiraDoencasHereditaria { get; set; }
        [StringLength(70)]
        public string SegundaDoencasHereditaria { get; set; }
        [StringLength(70)]
        public string TerceiraDoencasHereditaria { get; set; }
        [StringLength(70)]
        public string QuartaDoencasHereditaria { get; set; }

        [Required]
        public bool CirugiasRealizadas { get; set; }
        [StringLength(200)]
        public string PrimeiraCirugia { get; set; }
        [StringLength(200)]
        public string SegundaCirugia { get; set; }
        [StringLength(200)]
        public string TerceiraCirugia { get; set; }
        [StringLength(200)]
        public string QuartaCirugia { get; set; }

        [Required]
        public string EstadoPsicologico { get; set; }
        [Required]
        public int IdKwendy { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataAbertura { get; set; }
    }
}