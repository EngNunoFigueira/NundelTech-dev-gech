using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Getch_website.Models
{
    public class FichaMedicaDoAPadrinhado
    {
        [Required]
        public int ID { get; set; }
        [DataType(DataType.Date)]

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoApadrinhado { get; set; }

        public DateTime? DataAbertura { get; set; }
        [Required]
        [StringLength(3000)]
        [DataType(DataType.MultilineText)]
        public string RelatorioMedico { get; set; }
        [Required]
        public decimal PesoActual { get; set; }
        [Required]
        public decimal Altura { get; set; }
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
        public string EstadoPsicologico { get; set; }

        #region LIGACOES DE TABELAS
        public virtual Apadrinhado Apadrinhado { get; set; }
        public virtual List<ConsultaMedica> ConsultaMedica { get; set; }
        #endregion
    }
}