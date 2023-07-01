using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Getch_website.Models
{
    public class UnidadeCurricular
    {
        public int ID { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string AnoLectivo { get; set; }
        [Required]
        public string Semestre { get; set; }
        [Required]
        public decimal HorasLectivas { get; set; }
        [Required]
        public decimal IndiceDeReprovacao { get; set; }
        public bool requerMaterialEspecifico { get; set; }

        public string Notafinal_I { get; set; }
        public string Notafinal_II { get; set; }
        public string Notafinal_III { get; set; }

        #region LIGACOES DE TABELAS
        public virtual PlanoCurricular PlanoCurricular { get; set; }
        [Required]
        public int PlanoCurricularId { get; set; }
        public virtual NomeDisciplina NomeDisciplina { get; set; }
        [Required]
        public int NomeDisciplinaId { get; set; }
        public virtual Aproveitamento Aproveitamento { get; set; }
        [Required]
        public int AproveitamentoId { get; set; }
        #endregion
    }

}
