using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Getch_website.Models
{
    public class Kwendy
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(20890)]
        public string CodigoKwendy { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\d{0}-[a-zA-Z]\d$")]
        public string CodigoApadrinhado { get; set; }

        [Required]
        public DateTime? DataDeEntrada { get; set; }

        #region LIGACOES COM OUTRAS TABELAS
        public virtual Apadrinhado ApadrinhadoPai { get; set; }
        [Required]
        public int ApadrinhadoId { get; set; }

        public virtual SituacaoFamiliar SituacaoFamiliar { get; set; }
        [Required]
        public int situacaoFamiliarId { get; set; }

        public virtual CedulaPessoal CedulaPessoal { get; set; }

        #region TABELAS QUE NECESSITAM DO ID DO KWENDY
        public virtual List<PlanoCurricular> PlanoCurricular { get; set; }
        #endregion

        #endregion
    }

}