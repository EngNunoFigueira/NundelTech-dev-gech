using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Getch_website.Models
{
    public class PlanoCurricular
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoKwendy { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string NotaGeral { get; set; }

        [Required]
        public string InicioDoAnoLectivo { get; set; }

        #region LIGACOES DE TABELAS
        public NivelDeEnsino NivelDeEnsino { get; set; }
        [Required]
        public int NivelDeEnsinoId { get; set; }
        public Kwendy Kwendy { get; set; }
        [Required]
        public int KwendyId { get; set; }
        public InstitDeEnsino InstitDeEnsino { get; set; }
        [Required]
        public int InstitDeEnsinoId { get; set; }
        public virtual List<UnidadeCurricular> UnidadeCurricular { get; set; }
        #endregion
    }

}