using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Getch_website.Models
{
    public class FichaMedicaDoKwendy
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(20890)]
        public string CodigoKwendy { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataAbertura { get; set; }
        [Required]
        [StringLength(300)]
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
        public virtual Kwendy Kwendy { get; set; }
        [Required]
        public int KwendyId { get; set; }
        public virtual List<ConsultaMedicaKwendy> KconsultaMedica { get; set; }
        #endregion
    }
}